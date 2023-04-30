using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.Models;

namespace kutuphane.Helpers
{
    internal static class MemberHelper
    {
        internal static DataTable ReadMember()
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Member", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        internal static void InsertMember(Models.Member member)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "INSERT INTO Member(code, name, surname, phoneNumber, email, address) " +
                             "VALUES (@code, @name, @surname, @phoneNumber, @email, @address)";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = member.code;
                    cmd.Parameters.Add("name", MySqlDbType.Text);
                    cmd.Parameters["name"].Value = member.name;
                    cmd.Parameters.Add("surname", MySqlDbType.Text);
                    cmd.Parameters["surname"].Value = member.surname;
                    cmd.Parameters.Add("phoneNumber", MySqlDbType.Text);
                    cmd.Parameters["phoneNumber"].Value = member.phoneNumber;
                    cmd.Parameters.Add("email", MySqlDbType.Text);
                    cmd.Parameters["email"].Value = member.email;
                    cmd.Parameters.Add("address", MySqlDbType.Text);
                    cmd.Parameters["address"].Value = member.address;
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                    }

                }
            }
        }

        internal static void DeleteMember(int code)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "DELETE FROM Member WHERE code=@code";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = code;
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        trans.Commit();
                    }
                    catch (Exception e)
                    {
                        trans?.Rollback();
                    }

                }

            }
        }
        internal static Models.Member? ReadMember(int code)
        {
            MySqlConnection con = new MySqlConnection(Global.ConnectionString);
            con.Open();
            string sql = "SELECT * from Member where code=@code";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("code", MySqlDbType.Int32);
            cmd.Parameters["code"].Value = code;
            using (cmd)
            {
                using (var row = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!row.Read())
                        return null;

                    return new Models.Member
                    {
                        code = row.GetInt32("code"),
                        name = row.GetString("name"),
                        surname = row.GetString("surname"),
                        phoneNumber = row.GetString("phoneNumber"),
                        email = row.GetString("email"),
                        address = row.GetString("address"),
                    };
                }
            }
        }

        internal static void UpdateUye(Models.Member member)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "UPDATE MEMBER SET name=@name,surname=@surname,phoneNumber=@phoneNumber,email=@email,address=@address WHERE code=@code";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = member.code;
                    cmd.Parameters.Add("name", MySqlDbType.VarChar);
                    cmd.Parameters["name"].Value = member.name;
                    cmd.Parameters.Add("surname", MySqlDbType.VarChar);
                    cmd.Parameters["surname"].Value = member.surname;
                    cmd.Parameters.Add("phoneNumber", MySqlDbType.VarChar);
                    cmd.Parameters["phoneNumber"].Value = member.phoneNumber;
                    cmd.Parameters.Add("email", MySqlDbType.VarChar);
                    cmd.Parameters["email"].Value = member.email;
                    cmd.Parameters.Add("address", MySqlDbType.VarChar);
                    cmd.Parameters["address"].Value = member.address;

                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                    }
                }
            }
        }
        internal static DataTable ReadMemberBooks(int memberCode)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM RentedBook WHERE Member_code=@Member_code", con))
                {
                    cmd.Parameters.Add("Member_code", MySqlDbType.Int32);
                    cmd.Parameters["Member_code"].Value = memberCode;
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        internal static void InsertRentedBook(RentedBook rentedBook)
        {
            using (var con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (var transaction = con.BeginTransaction())
                {
                    var sql = "INSERT into RentedBook(Book_code,Member_code,RentDate,ReturnDate,User_code) " +
                        "VALUES(@Book_code,@Member_code,@RentDate,@ReturnDate,@User_code)";
                    var cmd = new MySqlCommand(sql, con, transaction);
                    cmd.Parameters.Add("Book_code", MySqlDbType.Int32);
                    cmd.Parameters["Book_code"].Value = rentedBook.Book_code;
                    cmd.Parameters.Add("Member_code", MySqlDbType.Int32);
                    cmd.Parameters["Member_code"].Value = rentedBook.Member_code;
                    cmd.Parameters.Add("RentDate", MySqlDbType.String);
                    cmd.Parameters["RentDate"].Value = rentedBook.RentDate;
                    cmd.Parameters.Add("ReturnDate", MySqlDbType.String);

                    if (rentedBook.ReturnDate == null)
                    {
                        cmd.Parameters["ReturnDate"].IsNullable = true;
                        cmd.Parameters["ReturnDate"].Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["ReturnDate"].Value = rentedBook.ReturnDate;
                    }
                    cmd.Parameters.Add("User_code", MySqlDbType.Int32);
                    cmd.Parameters["User_code"].Value = rentedBook.User_code;

                    try
                    {
                        using (cmd)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }

            }
        }
        internal static void UpdateRentedBook(RentedBook rentedBook)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "UPDATE RentedBook SET =@Book_code RentDate=@RentDate,ReturnDate=@ReturnDate,User_code=@User_code WHERE Member_code=Member_code";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("Book_code", MySqlDbType.Int32);
                    cmd.Parameters["Book_code"].Value = rentedBook.Book_code;
                    cmd.Parameters.Add("RentDate", MySqlDbType.String);
                    cmd.Parameters["RentDate"].Value = rentedBook.RentDate;
                    cmd.Parameters.Add("ReturnDate", MySqlDbType.String);
                    if (rentedBook.ReturnDate == null)
                    {
                        cmd.Parameters["ReturnDate"].IsNullable = true;
                        cmd.Parameters["ReturnDate"].Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["ReturnDate"].Value = rentedBook.ReturnDate;
                    }
                    cmd.Parameters.Add("User_code", MySqlDbType.Int32);
                    cmd.Parameters["User_code"].Value = rentedBook.User_code;
                    cmd.Parameters.Add("Member_code", MySqlDbType.Int32);
                    cmd.Parameters["Member_code"].Value = rentedBook.Member_code;

                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                    }
                }
            }
        }
        internal static RentedBook? ReadMemberBook(int memberCode, int BookCode, string rentdate,int userCode)
        {
            MySqlConnection con = new MySqlConnection(Global.ConnectionString);
            con.Open();
            string sql = "SELECT * from RentedBook where Member_code=@Member_code and Book_code=@Book_code and RentDate=@RentDate and User_code=@User_code";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("Member_code", MySqlDbType.Int32);
            cmd.Parameters["Member_code"].Value = memberCode;
            cmd.Parameters.Add("Book_code", MySqlDbType.Int32);
            cmd.Parameters["Book_code"].Value = BookCode;
            cmd.Parameters.Add("RentDate", MySqlDbType.String);
            cmd.Parameters["RentDate"].Value = rentdate;
            cmd.Parameters.Add("User_code", MySqlDbType.Int32);
            cmd.Parameters["User_code"].Value = userCode;
            using (cmd)
            {
                using (var row = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!row.Read())
                        return null;
                    return new RentedBook
                    {
                        Member_code = row.GetInt32("Member_code"),
                        Book_code = row.GetInt32("Book_code"),
                        RentDate = row.GetString("RentDate"),
                        ReturnDate = row.IsDBNull("ReturnDate") ? null : row.GetString("ReturnDate"),
                        User_code=row.GetInt32("User_code")
                    };
                }

            }

        }
    }


}

