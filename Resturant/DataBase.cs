using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Data;
namespace Resturant
{
    internal  static class DataBase
    {
        public static string str_connection = "Server=.;Database=Resturant;User Id=sa;Password=123456;";

        [Obsolete]
        public static bool checkLogin(string username, string password)
        {
            bool check=false;
            SqlConnection con=new SqlConnection(str_connection);
            string query = @"select * from Users where UserName=@username and Password=@password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                con.Open();
                SqlDataReader reader=command.ExecuteReader();
                while (reader.Read())
                {
                    USER = reader.GetValue(3).ToString();
                    check=true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return check;
        }

        public static int SQL(string qry,Hashtable ht)
        {
            int res = 0;
            SqlConnection connection = new SqlConnection(str_connection);
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType=CommandType.Text;
            try
            {
                connection.Open();
                foreach (DictionaryEntry item in ht)
                {
                    command.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                res = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
        public static void LoadData(string qry,DataGridView gv,ListBox lb)
        {
            SqlConnection connection=new SqlConnection(str_connection);
            SqlCommand command=new SqlCommand(qry, connection);
            command.CommandType=CommandType.Text;
            SqlDataAdapter da=new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string user;
        public static string USER
        {
            get { return user; }
            set { user = value; }
        }
    }    
    
}



