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

        internal static void DeleteData(List<string> lId)
        {
            try
            {
                var lines = ds.Tables["Students"].AsEnumerable().Where(s => lId.Contains(s.Field<string>("StId")));
                foreach (var line in lines)
                {
                    line.Delete();
                }

                adapter.Update(ds.Tables["Students"]);
            }
            catch (SqlException)
            {
                College1en.Home.UIMessage("Database: Deletion rejected");
            }
            catch (Exception)
            {
                College1en.Home.UIMessage("Data Layer: Deletion rejected");
            }
        }

        internal static void UpdateData(Student student)
        {
            try
            {
                var line = ds.Tables["Students"]
                    .AsEnumerable()
                    .Where(s => s.Field<string>("StId") == student.StId)
                    .SingleOrDefault();
                if (line != null)
                {
                    line.SetField("StName", student.StName);
                    line.SetField("ProgId", student.ProgId);
                    adapter.Update(ds.Tables["Students"]);
                }
            }
            catch (SqlException)
            {
                Home.UIMessage("Database: Update rejected");
            }
            catch (Exception)
            {
                Home.UIMessage("Data Layer: Update rejected");
            }
        }

        internal static void InsertData(Student student)
        {
            DataRow line = ds.Tables["Students"].NewRow();
            try
            {
                line.SetField("StId", student.StId);
                line.SetField("StName", student.StName);
                line.SetField("ProgId", student.ProgId);
                ds.Tables["Students"].Rows.Add(line);
                adapter.Update(ds.Tables["Students"]);
            }
            catch (SqlException)
            {
                Home.UIMessage("Database: Insertion rejected");
            }
            catch (Exception)
            {
                Home.UIMessage("Data Layer: Insertion rejected");
            }
        }
    }

    internal class Student
    {
        public string StId;
        public string StName;
        public string ProgId;
    }
}
