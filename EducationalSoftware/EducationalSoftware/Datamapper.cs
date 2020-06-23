using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Globalization;

namespace EducationalSoftware
{
    class Datamapper
    {
        OleDbConnection connection;

       public Datamapper()
        {
            GetConnection();
        }
        /// <summary>
        /// Gets the connection string. Must be initialized once before any other method from the DataMapper is used by a class.
        /// </summary>
        public void GetConnection()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database2.accdb";
            connection=new OleDbConnection(connetionString);
        }
        /// <summary>
        /// Tries to open the connection and returns true if succeeded or false if not.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Tries to close the connection and returns true if succeeded or false if not.
        /// </summary>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        private byte[] GenerateHash(string pass,byte[] salt)
        {
            byte[] text = Encoding.ASCII.GetBytes(pass);

            HashAlgorithm alg = new SHA256Managed();
            byte[] txt_salt = new byte[text.Length + salt.Length];

            for (int i = 0; i < pass.Length; i++)
            {
                txt_salt[i] = text[i];
            }

            for (int i = 0; i < salt.Length; i++)
            {
                txt_salt[text.Length + i] = salt[i];
            }

            return alg.ComputeHash(txt_salt);
        }

        /// <summary>
        /// Creates new entry in database, with hash n salt for the password.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool Register(string user, string pass)
        {
            try
            {
                //password salt and hashing
                byte[] salt;

                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                byte[] hash = GenerateHash(pass, salt);

                //convert byte to equivelant string
                string str_salt = Convert.ToBase64String(salt);
                string str_hash = Convert.ToBase64String(hash);

                OpenConnection();
                string cmd = "INSERT INTO [students] ([username],[password],[salt]) VALUES (@user,@pass,@salt);";
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", str_hash);
                command.Parameters.AddWithValue("@salt", str_salt);
                command.ExecuteNonQuery();
                cmd ="INSERT INTO [Stats]([Username],[Stat_1],[Stat_2],[Stat_3],[Stat_4],[Stat_5],[Stat_6],[Stat_7],[Stat_8],[Stat_9],[Stat_10]) VALUES(@username,10, 10, 10, 10, 10, 10, 10, 10, 10, 10)";
                command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@username", user);
                command.ExecuteNonQuery();
                cmd = "INSERT INTO [Multipliers]([Username],[multiplier_1],[multiplier_2],[multiplier_3],[multiplier_4],[multiplier_5],[multiplier_6],[multiplier_7],[multiplier_8],[multiplier_9],[multiplier_10]) VALUES(@username,1, 1, 1, 1, 1, 1, 1, 1, 1, 1)";
                command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@username", user);
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Gets the multiplier for the stats or given user and returns them as a float array.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public float[] GetMultipliers(string username)
        {
            string cmd = "SELECT multiplier_1,multiplier_2,multiplier_3,multiplier_4,multiplier_5,multiplier_6,multiplier_7,multiplier_8,multiplier_9,multiplier_10 FROM Multipliers WHERE Username=?";
            float[] multipliers = new float[10];
            OleDbCommand command = new OleDbCommand(cmd, connection);
            command.Parameters.AddWithValue("@username", username);
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
        /// <summary>
        /// Gets stats of given user and returns them as a float array.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public float[] GetStats(string username)
        {
            string cmd = "SELECT [Stat_1],[Stat_2],[Stat_3],[Stat_4],[Stat_5],[Stat_6],[Stat_7],[Stat_8],[Stat_9],[Stat_10] FROM Stats WHERE [Username]=@username";
            float[] stats = new float[10];
            OleDbCommand command = new OleDbCommand(cmd,connection);
            command.Parameters.AddWithValue("@username",username);
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
        /// <summary>
        /// Updates stats into the databse.
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="username"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Updates multipliers into database.
        /// </summary>
        /// <param name="multipliers"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool SaveMultipliers(float[] multipliers, string username)
        {
            try
            {
                string cmd = "UPDATE [Multipliers] SET [multiplier_1] = @multiplier_1,[multiplier_2] = @multiplier_2,[multiplier_3] = @multiplier_3,[multiplier_4] = @multiplier_4,[multiplier_5] = @multiplier_5,[multiplier_6] = @multiplier_6,[multiplier_7] = @multiplier_7,[multiplier_8] = @multiplier_8,[multiplier_9] = @multiplier_9,[multiplier_10] = @multiplier_10 WHERE [Username]=@username";
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

        public int[] GetStatistics(string username, DateTime date)
        {
            try
            {
                string year = date.Year.ToString();
                string month = date.Month.ToString();
                string day = date.Day.ToString();
                string cmd = "SELECT * FROM Statistics WHERE [Username]=@username AND Year([Date]) >= @year AND Month([Date])>= @month AND Day([Date])>=@day";
                int[] statistics = new int[20];
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@year",year);
                command.Parameters.AddWithValue("@month",month);
                command.Parameters.AddWithValue("@day", day);
                OpenConnection();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            statistics[i] += int.Parse(reader[i+3].ToString());
                        }

                    }
                }
                CloseConnection();
                return statistics;
            }
            catch(Exception e)
            {
                throw new Exception("Data error.");
            }
        }

        public bool SaveStatistics(string username,int[] statistics)
        {
            try
            {
                int exists = 0;
                /*
                string date;
                if (datet.Month > 9)
                {
                    date = datet.ToString("MM/dd/yyyy");
                }
                else
                {
                    date = datet.ToString("M/dd/yyyy");
                }
                */
                int date = Convert.ToInt32(DateTime.Now.ToOADate());//αυτη η γραμμη μετατρέπει σε αριθμό, εαν την σβησεις ΘΥΜΗΣΟΥ ΝΑ ΑΛΛΑΞΕΙΣ ΣΤΗΝ ΒΑΣΗ ΤΟΝ ΤΥΠΟ του date
                string cmd = "SELECT * FROM [Statistics] WHERE [username]=@username AND [date]=@date";
                OleDbCommand command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                OpenConnection();
                exists=Convert.ToInt32(command.ExecuteScalar());
                if (exists > 0)
                {
                    cmd = "UPDATE [Statistics] SET [right_1]=@right_1,[wrong_1]=@wrong_1,[right_2]=@right_2,[wrong_2]=@wrong_2,[right_3]=@right_3,[wrong_3]=@wrong_3,[right_4]=@right_4,[wrong_4]=@wrong_4,[right_5]=@right_5,[wrong_5]=@wrong_5,[right_6]=@right_6,[wrong_6]=@wrong_6,[right_7]=@right_7,[wrong_7]=@wrong_7,[right_8]=@right_8,[wrong_8]=@wrong_8,[right_9]=@right_9,[wrong_9]=@wrong_9,[right_10]=@right_10,[wrong_10]=@wrong_10 WHERE [username]=@username AND [date]=44006";
                }
                else
                {
                    cmd = "INSERT INTO [Statistics] ([username],[date],[right_1],[wrong_1],[right_2],[wrong_2],[right_3],[wrong_3],[right_4],[wrong_4],[right_5],[wrong_5],[right_6],[wrong_6],[right_7],[wrong_7],[right_8],[wrong_8],[right_9],[wrong_9],[right_10],[wrong_10]) VALUES (@username,@date,@right_1,@wrong_1,@right_2,@wrong_2,@right_3,@wrong_3,@right_4,@wrong_4,@right_5,@wrong_5,@right_6,@wrong_6,@right_7,@wrong_7,@right_8,@wrong_8,@right_9,@wrong_9,@right_10,@wrong_10)";
                }

                command = new OleDbCommand(cmd, connection);
                command.Parameters.AddWithValue("@username", username);
                //command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@right_1", statistics[0]);
                command.Parameters.AddWithValue("@wrong_1", statistics[1]);
                command.Parameters.AddWithValue("@right_2", statistics[2]);
                command.Parameters.AddWithValue("@wrong_2", statistics[3]);
                command.Parameters.AddWithValue("@right_3", statistics[4]);
                command.Parameters.AddWithValue("@wrong_3", statistics[5]);
                command.Parameters.AddWithValue("@right_4", statistics[6]);
                command.Parameters.AddWithValue("@wrong_4", statistics[7]);
                command.Parameters.AddWithValue("@right_5", statistics[8]);
                command.Parameters.AddWithValue("@wrong_5", statistics[9]);
                command.Parameters.AddWithValue("@right_6", statistics[10]);
                command.Parameters.AddWithValue("@wrong_6", statistics[11]);
                command.Parameters.AddWithValue("@right_7", statistics[12]);
                command.Parameters.AddWithValue("@wrong_7", statistics[13]);
                command.Parameters.AddWithValue("@right_8", statistics[14]);
                command.Parameters.AddWithValue("@wrong_8", statistics[15]);
                command.Parameters.AddWithValue("@right_9", statistics[16]);
                command.Parameters.AddWithValue("@wrong_9", statistics[17]);
                command.Parameters.AddWithValue("@right_10", statistics[18]);
                command.Parameters.AddWithValue("@wrong_10", statistics[19]);

                int rows =command.ExecuteNonQuery();

                Console.WriteLine("Rows: " + rows.ToString());
                CloseConnection();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public bool LoginUser(string username, string password)
        {
            try
            {
                string fetcher = "Select [password],[salt] From students Where [username] = @user";
                OleDbCommand command = new OleDbCommand(fetcher, connection);
                command.Parameters.AddWithValue("@user", username);
                OpenConnection();
                string hashedpass = null;
                string salt = null;
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hashedpass = reader[0].ToString();
                        salt = reader[1].ToString();
                    }
                }
                CloseConnection();
                //extracts the bytes.
                byte[] hashed = Convert.FromBase64String(hashedpass);
                //retrieving the salt.
                byte[] saltBytes = Convert.FromBase64String(salt);
                byte[] newhash = GenerateHash(password, saltBytes);

                //compare results.
                if (newhash.Length != hashed.Length)
                {
                    throw new UnauthorizedAccessException();
                }

                for(int i = 0; i < hashed.Length; i++)
                {
                    if (hashed[i] != newhash[i])
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
