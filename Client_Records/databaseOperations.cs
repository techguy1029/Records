using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Records
{
    public class databaseOperations
    {
        public static bool setUpLocalDb()
        {
            String str;
            SqlConnection myConn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Integrated security=SSPI;database=master");
            str = "CREATE DATABASE recordsData ON PRIMARY" +
                 "(NAME = recordsProject_Data, " +
                  "FILENAME = 'C:\\ProgramData\\Records\\Data.mdf', " +
                  "SIZE = 2MB, MAXSIZE = 20MB, FILEGROWTH = 10%) " +
                  "LOG ON (NAME = MyDatabase_Log, " +
                  "FILENAME = 'C:\\ProgramData\\contractorCalc\\Data.ldf', " +
                  "SIZE = 1MB, " +
                  "MAXSIZE = 10MB, " +
                  "FILEGROWTH = 10%)";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DB IS SUCCESS");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            return true;
        }
        public static void setUpDbStructure()
        {
            SqlConnection myConn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Integrated security=SSPI;database=recordsData");
            String createTable = "CREATE TABLE Customers(ID int IDENTITY, firstName varchar(150), lastName varchar(150), Address varchar(150), phoneNumber varchar(150), alternatePhoneNumber varchar(150), billingAddress varchar(150))";
            SqlCommand createTableSQL = new SqlCommand(createTable, myConn);
            try
            {
                myConn.Open();
                createTableSQL.ExecuteNonQuery();
                MessageBox.Show("Table success");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
