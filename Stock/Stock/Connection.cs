using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public static class Connection
    {
         public static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static SqlConnection GetConnection()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StockConn"].ConnectionString;
            //MessageBox.Show(appPath);
            string filename = @"DatabaseStock.mdf";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + filename;
            //MessageBox.Show(filePath);
            appPath = "e:\\informatikai_projektum\\Stock\\Stock";
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\DatabaseStock.mdf;Integrated Security=True");
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filePath + ";Integrated Security=True");
            MessageBox.Show(sqlConnection.ConnectionString.ToString());
            return sqlConnection;
            //return con;
        }
    }
}
