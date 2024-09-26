using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbconnection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DBConnection dbCon = DBConnection.Instance();
            dbCon.Server = "sql10.freesqldatabase.com";
            dbCon.DatabaseName = "sql10733542";
            dbCon.UserName = "sql10733542";
            dbCon.Password = "ac1VlfvwVE";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                
                string query = "select id,nome,cpf from Pessoas";
                var cmd = new MySqlCommand(query, dbCon.Connection);
              
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    Console.WriteLine($"ID:{reader.GetInt32(0)},NOME:{reader.GetString(1)},CPF:{reader.GetString(2)}");
                }

                dbCon.Close();
                Console.WriteLine("Press ENTER to Exit");
                Console.ReadLine();
            }
            
        }
    }
}


