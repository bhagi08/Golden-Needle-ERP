using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    public class DBconnect
    {
        private SqlConnection conn;
        public SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;


        public DBconnect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-ROF2H0M\BHAGI;Initial Catalog=Golden;Integrated Security=True");
            
        }


        public void SqlQuery(string qryTxt)
        {
            cmd = new SqlCommand(qryTxt, conn);

        }

        public DataTable SelQryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

       public SqlDataReader SelQryRedEx()
       {
           dr = cmd.ExecuteReader();
           return dr;
           
       }

        public void InsQryEx()
        {
            cmd.ExecuteNonQuery();
        }


         public  void DBclose()
        {
            conn.Close();
        }

        public void DBopen()
         {
             conn.Open();
         }
    }
}
