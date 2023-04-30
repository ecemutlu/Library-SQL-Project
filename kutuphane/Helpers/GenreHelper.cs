using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

namespace kutuphane.Helpers
{
    internal static class GenreHelper
    {
        internal static DataTable ReadGenres(string conString)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Genre", con))
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

        internal static void InsertTur(string constring, Models.Genre tur)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "INSERT INTO Genre(code,name)" +
                        "VALUES(@code,@name)";
                    MySqlCommand cmd = new MySqlCommand(sql, con, trans);

                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = tur.code;
                    cmd.Parameters.Add("name", MySqlDbType.Text);
                    cmd.Parameters["name"].Value = tur.name;

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
        internal static void DeleteTur(string conString, int code)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "DELETE FROM Genre WHERE code in (@code) ";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value =code;
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
        internal static Models.Genre? ReadTur(string conString, int code)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT * from Genre where code=@code";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("code", MySqlDbType.Int32);
            cmd.Parameters["code"].Value = code;
            using (cmd)
            {
                using (var row = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!row.Read())
                        return null;

                    return new Models.Genre
                    {
                        code = row.GetInt32("code"),
                        name = row.GetString("name"),
                    };
                }
            }
        }
        internal static void UpdateTur(string conString, Models.Genre tur)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (var trans = con.BeginTransaction())
                {
                    var sql = "UPDATE Genre SET name=@name WHERE code=@code ";
                    var cmd = new MySqlCommand(sql, con, trans);
                    cmd.Parameters.Add("code", MySqlDbType.Int32);
                    cmd.Parameters["code"].Value = tur.code;
                    cmd.Parameters.Add("name", MySqlDbType.VarChar);
                    cmd.Parameters["name"].Value = tur.name;
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


