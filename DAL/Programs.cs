using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace College1en.DAL
{
    internal class Programs
    {
        static SqlDataAdapter adapter;
        static DataSet ds;
        static bool init = false;

        internal static DataTable GetData()
        {
            if (!init)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                adapter = new SqlDataAdapter("SELECT * FROM Programs", connectionString);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                ds = new DataSet();
                adapter.Fill(ds, "Programs");

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();

                init = true;
            }
            return ds.Tables["Programs"];
        }

        internal static void DeleteData(List<string> lId)
        {
            try
            {
                var lines = ds.Tables["Programs"].AsEnumerable().Where(s => lId.Contains(s.Field<string>("ProgId")));
                foreach (var line in lines)
                {
                    line.Delete();
                }

                adapter.Update(ds.Tables["Programs"]);
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

        internal static void UpdateData(StudyProgram program)
        {
            try
            {
                var line = ds.Tables["Programs"]
                    .AsEnumerable()
                    .Where(s => s.Field<string>("ProgId") == program.ProgId)
                    .SingleOrDefault();
                if (line != null)
                {
                    line.SetField("ProgId", program.ProgId);
                    line.SetField("ProgName", program.ProgName);
                    adapter.Update(ds.Tables["Programs"]);
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

        internal static void InsertData(StudyProgram program)
        {
            DataRow line = ds.Tables["Programs"].NewRow();
            try
            {
                line.SetField("ProgId", program.ProgId);
                line.SetField("ProgName", program.ProgName);
                ds.Tables["Programs"].Rows.Add(line);
                adapter.Update(ds.Tables["Programs"]);
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

    internal class StudyProgram // is Program a keyword?
    {
        public string ProgId;
        public string ProgName;
    }
}
