using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

namespace kutuphane.Helpers
{
    internal static class BookHelper
    {
        internal static DataTable ReadBooks()
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Book", con))
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
        internal static void InsertBook(string conString, Models.Book Book)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "INSERT INTO Book(code,ReleaseDate,ReleasePlace,numberOfPages,nameOfBook,Author_code,User_code,Publisher_code)" +
                        "VALUES(@code,@ReleaseDate,@ReleasePlace,@numberOfPages,@nameOfBook,@Author_code,@User_code,@Publisher_code)";
                    MySqlCommand cmd = new MySqlCommand(sql, con, trans);

                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = Book.code;
                    cmd.Parameters.Add("ReleaseDate", MySqlDbType.Text);
                    cmd.Parameters["ReleaseDate"].Value = Book.ReleaseDate;
                    cmd.Parameters.Add("ReleasePlace", MySqlDbType.Text);
                    cmd.Parameters["ReleasePlace"].Value = Book.ReleasePlace;
                    cmd.Parameters.Add("numberOfPages", MySqlDbType.Int32);
                    cmd.Parameters["numberOfPages"].Value = Book.numberOfPages;
                    cmd.Parameters.Add("nameOfBook", MySqlDbType.Text);
                    cmd.Parameters["nameOfBook"].Value = Book.nameOfBook;
                    cmd.Parameters.Add("Author_code", MySqlDbType.Int32);
                    cmd.Parameters["Author_code"].Value = Book.Author_code;
                    cmd.Parameters.Add("User_code", MySqlDbType.Int32);
                    cmd.Parameters["User_code"].Value = Book.User_code;
                    cmd.Parameters.Add("Publisher_code", MySqlDbType.Int32);
                    cmd.Parameters["Publisher_code"].Value = Book.Publisher_code;
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
        internal static void DeleteBook(string conString, int code)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "DELETE FROM Book WHERE code in (@code) ";
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
        internal static Models.Book? ReadBook(string conString, int code)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT * from Book where code=@code";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("code", MySqlDbType.Int32);
            cmd.Parameters["code"].Value = code;
            using (cmd)
            {
                using (var row = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!row.Read())
                        return null;

                    return new Models.Book
                    {
                        code = row.GetInt32("code"),
                        nameOfBook = row.GetString("nameOfBook"),
                        numberOfPages = row.GetInt32("numberOfPages"),
                        ReleaseDate = row.GetString("ReleaseDate"),
                        ReleasePlace= row.GetString("BasimYeri"),
                        Author_code = row.GetInt32("Author_code"),
                        User_code=row.GetInt32("User_code"),
                        Publisher_code = row.GetInt32("Publisher_code")
                    };
                }
            }
        }
        internal static void UpdateBook(string conString, Models.Book Book)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "UPDATE Book SET numberOfPages=@numberOfPages,nameOfBook=@nameOfBook,ReleaseDate=@ReleaseDate,ReleasePlace=@ReleasePlace WHERE code=@code";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("numberOfPages", MySqlDbType.Int32);
                    cmd.Parameters["numberOfPages"].Value = Book.numberOfPages;
                    cmd.Parameters.Add("nameOfBook", MySqlDbType.VarChar);
                    cmd.Parameters["nameOfBook"].Value = Book.nameOfBook;
                    cmd.Parameters.Add("ReleaseDate", MySqlDbType.String);
                    if (Book.ReleaseDate == null)
                        cmd.Parameters["ReleaseDate"].Value = null;
                    else
                    cmd.Parameters["ReleaseDate"].Value = Book.ReleaseDate;
                    cmd.Parameters.Add("ReleasePlace", MySqlDbType.VarChar);
                    cmd.Parameters["ReleasePlace"].Value = Book.ReleasePlace;
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = Book.code;
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
    }
}






