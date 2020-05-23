using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EducationalSoftware
{
    class Datamapper
    {
        public static OleDbConnection connection;
        /// <summary>
        /// Gets the cionnection string. Must be initialized once before any other method from the DataMapper is used by a class.
        /// </summary>
        public static void getConnection()
        OleDbConnection connection;
        public void GetConnection()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database.accdb";
            connection=new OleDbConnection(connetionString);
        }
        public bool OpenConnection()
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
        public void CloseConnection()
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
        public float[] GetMultipliers(string username)
        {
            string cmd = "SELECT multiplier_1,multiplier_2,multiplier_3,multiplier_4,multiplier_5,multiplier_6,multiplier_7,multiplier_8,multiplier_9,multiplier_10 FROM Multipliers WHERE Username=?";
            float[] multipliers = new float[10];
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@username", username);
            int index = 0;
            OpenConnection();
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        multipliers[i] = float.Parse(reader[i].ToString());
                    }

                }
            }
            CloseConnection();
            return multipliers;

        }
        public float[] GetStats(string username)
        {
            string cmd = "SELECT Stat_1,Stat_2,Stat_3,Stat_4,Stat_5,Stat_6,Stat_7,Stat_8,Stat_9,Stat_10 FROM Stats WHERE Username=?";
            float[] stats = new float[10];
            OleDbCommand command = new OleDbCommand(cmd,connection);
            command.Parameters.AddWithValue("@username",username);
            int index = 0;
            OpenConnection();
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for(int i =0; i<10; i++)
                    {
                        stats[i] = float.Parse(reader[i].ToString());
                    }
                  
                }
            }
            CloseConnection();
            return stats;

        }
        public bool SaveStats(float[] stats,string username)
        {
            try
            {
                string cmd = "UPDATE Stats SET Stat_1 = ?,Stat_2= ?,Stat_3= ?,Stat_4= ?,Stat_5= ?,Stat_6= ?,Stat_7= ?,Stat_8= ?,Stat_9= ?,Stat_10= ? WHERE Username=?";
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@Stat_1", stats[0]);
                command.Parameters.AddWithValue("@Stat_2", stats[1]);
                command.Parameters.AddWithValue("@Stat_3", stats[2]);
                command.Parameters.AddWithValue("@Stat_4", stats[3]);
                command.Parameters.AddWithValue("@Stat_5", stats[4]);
                command.Parameters.AddWithValue("@Stat_6", stats[5]);
                command.Parameters.AddWithValue("@Stat_7", stats[6]);
                command.Parameters.AddWithValue("@Stat_8", stats[7]);
                command.Parameters.AddWithValue("@Stat_9", stats[8]);
                command.Parameters.AddWithValue("@Stat_10", stats[9]);
                command.Parameters.AddWithValue("@username", username);
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool SaveMultipliers(float[] multipliers, string username)
        {
            try
            {
                string cmd = "UPDATE Stats SET multiplier_1 = ?,multiplier_2= ?,multiplier_3= ?,multiplier_4= ?,multiplier_5= ?,multiplier_6= ?,multiplier_7= ?,multiplier_8= ?,multiplier_9= ?,multiplier_10= ? WHERE Username=?";
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@multiplier_1", multipliers[0]);
                command.Parameters.AddWithValue("@multiplier_2", multipliers[1]);
                command.Parameters.AddWithValue("@multiplier_3", multipliers[2]);
                command.Parameters.AddWithValue("@multiplier_4", multipliers[3]);
                command.Parameters.AddWithValue("@multiplier_5", multipliers[4]);
                command.Parameters.AddWithValue("@multiplier_6", multipliers[5]);
                command.Parameters.AddWithValue("@multiplier_7", multipliers[6]);
                command.Parameters.AddWithValue("@multiplier_8", multipliers[7]);
                command.Parameters.AddWithValue("@multiplier_9", multipliers[8]);
                command.Parameters.AddWithValue("@multiplier_10", multipliers[9]);
                command.Parameters.AddWithValue("@username", username);
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
