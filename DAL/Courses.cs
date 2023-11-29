using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1en.DAL
{
    internal class Courses
    {
        static SqlDataAdapter adapter;
        static DataSet ds;
        static bool init = false;

        internal static DataTable GetData()
        {
            if (!init)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                adapter = new SqlDataAdapter("SELECT * FROM Courses", connectionString);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                ds = new DataSet();
                adapter.Fill(ds, "Courses");

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();

                init = true;
            }
            return ds.Tables["Courses"];
        }
    }
}
