using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using kutuphane.Models;

namespace kutuphane.Helpers
{
    internal class Author_Publisher_UserHelper
    {
        internal static DataTable ReadAuthours()
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Author", con))
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
        internal static DataTable ReadPublishers()
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Publisher", con))
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
        internal static DataTable ReadUsers()
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM User", con))
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

        internal static User? ReadUser(string username)
        {
            using (MySqlConnection con = new MySqlConnection(Global.ConnectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM User WHERE username=@username", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("username", MySqlDbType.String);
                    cmd.Parameters["username"].Value = username;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new User
                            {
                                code = reader.GetInt32("code"),
                                username = reader.GetString("username"),
                                email = reader.GetString("email"),
                                name = reader.GetString("name"),
                                password = reader.GetString("password"),
                                phoneNumber=reader.GetString("phoneNumber"),
                                surname= reader.GetString("surname")
                            };
                        else
                            return null;
                    }
                }
            }
        }
    }

}
