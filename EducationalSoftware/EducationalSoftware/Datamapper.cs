using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EducationalSoftware
{
    class Datamapper
    {
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
        public float[] GetStats(string username)
        {
            string cmd = "SELECT Stat_1,Stat_2,Stat_3,Stat_4,Stat_5,Stat_6,Stat_7,Stat_8,Stat_9,Stat_10 FROM Students WHERE Username=?";
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
                string cmd = "UPDATE Students SET Stat_1 = ?,Stat_2= ?,Stat_3= ?,Stat_4= ?,Stat_5= ?,Stat_6= ?,Stat_7= ?,Stat_8= ?,Stat_9= ?,Stat_10= ? WHERE Username=?";
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
    }
}
