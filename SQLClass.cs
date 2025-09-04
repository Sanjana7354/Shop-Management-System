using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    internal class SQLClass
    {
        public string connection_string = "Server=PRAJAPATI\\SQLEXPRESS;databace=shopDB;User Id=sa;Password=26082004";
        private SqlConnection con = new SqlConnection()
        {
            ConnectionString = "Server=PRAJAPATI\\SQLEXPRESS;database=shopDB;User Id=sa;Password=26082004"
        };
        private SqlCommand sqlcmd;
        public SqlDataAdapter sqlda;
        public DataSet sqlds;
        public DataTable dt;
        public SqlDataReader reader;

        public int recordcount;
        public void Execute_Query(string query1)
        {
            try 
            {

                con.Open();
                sqlcmd = new SqlCommand(query1, con);
                sqlda = new SqlDataAdapter(sqlcmd);
                sqlds = new DataSet();
                recordcount = 0;
                recordcount = sqlda.Fill(sqlds);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insert_Query(string query1)
        {
            try
            {

                con.Open();
                sqlcmd = new SqlCommand(query1, con);
                sqlda = new SqlDataAdapter(sqlcmd);
                sqlds = new DataSet();
                recordcount = 0;
                recordcount = sqlda.Fill(sqlds);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Update(string query1)
        {
            try
            {

                con.Open();
                sqlcmd = new SqlCommand(query1, con);
                sqlda = new SqlDataAdapter(sqlcmd);
                sqlds = new DataSet();
                recordcount = 0;
                recordcount = sqlda.Fill(sqlds);
                

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
