using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project001
{
    class databaseconnection
    {
        SqlConnection CON = new SqlConnection("Data Source=CSASWCHATHURANG;Initial Catalog=Golden;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
    }
}
