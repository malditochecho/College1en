using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

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

        internal static void DeleteData(List<string> lId)
        {
            try
            {
                var lines = ds.Tables["Courses"].AsEnumerable().Where(s => lId.Contains(s.Field<string>("CId")));
                foreach (var line in lines)
                {
                    line.Delete();
                }

                adapter.Update(ds.Tables["Courses"]);
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

        internal static void UpdateData(Course course)
        {
            try
            {
                var line = ds.Tables["Courses"]
                    .AsEnumerable()
                    .Where(s => s.Field<string>("CId") == course.CId)
                    .SingleOrDefault();
                if (line != null)
                {
                    line.SetField("CName", course.CName);
                    line.SetField("ProgId", course.ProgId);
                    adapter.Update(ds.Tables["Courses"]);
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

        internal static void InsertData(Course course)
        {
            DataRow line = ds.Tables["Courses"].NewRow();
            try
            {
                line.SetField("CId", course.CId);
                line.SetField("CName", course.CName);
                line.SetField("ProgId", course.ProgId);
                ds.Tables["Courses"].Rows.Add(line);
                adapter.Update(ds.Tables["Courses"]);
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

    internal class Course
    {
        public string CId;
        public string CName;
        public string ProgId;
    }
}
