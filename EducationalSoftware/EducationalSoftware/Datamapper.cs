using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace EducationalSoftware
{
    class Datamapper
    {
        public static OleDbConnection connection;
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
    }
}
