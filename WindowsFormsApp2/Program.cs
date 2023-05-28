using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            //NpgsqlConnection conn = Connection.GetConnection();
            //try
            //{
            //    conn.Open();
            //    //string sql = @"select * from client";
            //    //NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            //    //DataTable dt = new DataTable();
            //    Console.WriteLine("OK!!!!");
            //    using (var command = new NpgsqlCommand("SELECT * FROM client", conn))
            //    {
            //        var reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(
            //                string.Format(
            //                    "Reading from table=({0}, {1}, {2}, {3}, {4})",
            //                    reader.GetInt32(0).ToString(),
            //                    reader.GetString(1).ToString(),
            //                    Convert.ToString(reader["birth_date"]),
            //                    reader.GetString(3).ToString(),
            //                    reader.GetString(4).ToString()
            //                    )
            //                );
            //        }
            //        reader.Close();
            //    }

            //    //dt.Load(cmd.ExecuteReader());
            //    conn.Close();
            //    //dgvData.DataSource = null;

            //}
            //catch (Exception ex)
            //{
            //    conn.Close();

            //    MessageBox.Show("Error: " + ex.Message);
            //    Console.WriteLine("ERROR!!!!");
            //    Console.WriteLine(ex.Message);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }

    public class Connection
    {
        static string connstring = String.Format("Server={0};Port={1};" +
               "User Id={2};Password={3};Database={4};", "localhost",
               5432, "postgres", "12345", "mydatabase");
        static NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public static NpgsqlConnection GetConnection()
        {
            return conn;
        }
    }

    public static class MyUser
    {
        private static string login;

        public static void SetLogin(string value)
        {
            login = value;
        }

        public static string GetLogin()
        {
            return login;
        }
    }
}
