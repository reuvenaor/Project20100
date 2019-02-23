/// <summary>
/// Project in WebApplication Reuven Naor
/// </summary>
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project
{
    public static class DB
    {
        /*  Variables
         */
        private static SqlConnection connect;
        private static SqlCommand command;
        private static SqlDataReader reader;
        // admin info here..
        private static string suName = "admin";
        private static string suPass = "1234";

        /*  Connect Method
         */
        public static void Connect()
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\rooby\Documents\pDB.mdf;
                                        Integrated Security=True;Connect Timeout=30");
            connect.Open();
        }

        /*  Disconnect Method
         */
        public static void Disconnect()
        {
            connect.Close();
        }

        /*  Checks if User is admin
        */
        public static Boolean IsAdmin(string name, string pass)
        {
            Boolean result = false;

            if (name == suName && pass == suPass)
            {
                result = true;

            }
            return result;
        }

        /*  Chek if user exsits
        */
        public static string IsUser(string name, string pass)
        {
            string id = null;

            string query = "select * from Users";

            command = new SqlCommand(query, connect);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                string n = (string)reader["name"];
                string p = (string)reader["password"];

                if (name == n.Trim() && pass == p.Trim())
                {
                    id = reader.GetString(0);              
                    break;
                }
            }
            reader.Close();
       
            return id; 
        }

        /*  Give back list of user info from Customers table and by id 
         */
        public static List<string> UserLookUp(string id)
        {
            List<string> l = new List<string>();

            string query = "select * from Customers";
            command = new SqlCommand(query, connect);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == id)          
                {
                    l.Add(reader.GetString(0));
                    l.Add(reader.GetString(1));         
                    l.Add(reader.GetString(2));
                    l.Add(reader.GetString(3));
                    l.Add(reader.GetString(4));
                    l.Add(reader.GetString(5));
                }
            }
            reader.Close();
            return l;
        }

        /*  ! sign '-' to Withdraw or sign '+' to Deposit 
         *  ! return Current Balance 
        */
        public static int Action(string idx, int amount, char sign)
        {
            int totalAmount = 0;
            int sumInt = 0;
            string query = "select * from Accounts";

            command = new SqlCommand(query, connect);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == idx)
                {
                    totalAmount = Convert.ToInt32(reader["sum"]);
                }
            }
            reader.Close();
            if(sign == '+')
            {
                sumInt = totalAmount + amount;
                query = "update Accounts set sum = " + sumInt + " where id = " + idx;
            }
            else if (sign == '-')
            {
                sumInt = totalAmount - amount;
                query = "update Accounts set sum = " + sumInt + " where id = " + idx + "";

            }
            Console.WriteLine(query);
            command = new SqlCommand(query, connect);
            command.ExecuteNonQuery();

            return sumInt;
        }

    }

}