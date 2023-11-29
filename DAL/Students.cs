using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using College1en.DAL;

namespace College1en.DAL
{
    internal class Students
    {
        static SqlDataAdapter adapter;
        static DataSet ds;
        static bool init = false;

        internal static DataTable GetData()
        {
            if (!init)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                adapter = new SqlDataAdapter("SELECT * FROM Students", connectionString);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                ds = new DataSet();
                adapter.Fill(ds, "Students");

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();

                init = true;
            }
            return ds.Tables["Students"];
        }
    }
}
