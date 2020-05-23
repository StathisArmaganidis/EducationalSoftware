using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace EducationalSoftware
{
    class Datamapper
    {
        public static OleDbConnection connection;
        /// <summary>
        /// Gets the cionnection string. Must be initialized once before any other method from the DataMapper is used by a class.
        /// </summary>
        public static void getConnection()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";
            connection=new OleDbConnection(connetionString);
        }
        public static bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public static void closeConnection()
        {
            connection.Close();
        }

        public static bool Register(string user, string pass)
        {
            try
            {
                openConnection();

                //passwrod salt and hashing
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                var pk = new Rfc2898DeriveBytes(pass, salt, 10000);
                byte[] hash = pk.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string encryptedPass = Convert.ToBase64String(hashBytes);

                string cmd = "INSERT INTO students ([username],[password],stat_1,stat_2,stat_3,stat_4,stat_5,stat_6,stat_7,stat_8,stat_9,stat_10) VALUES (@user,@pass,10,10,10,10,10,10,10,10,10,10)";
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@user",OleDbType.LongVarChar).Value = user;
                command.Parameters.AddWithValue("@pass", OleDbType.LongVarChar).Value = encryptedPass;

                command.ExecuteNonQuery();
                
                closeConnection();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
