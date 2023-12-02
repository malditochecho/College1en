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
    internal class Enrollments
    {
        static SqlDataAdapter adapter;
        static DataSet ds;
        static bool init = false;

        internal static DataTable GetData()
        {
            if (!init)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                string query = "SELECT DISTINCT " +
                    "s.StId, s.StName, c.CId, c.CName, e.FinalGrade, p.ProgId, p.ProgName " +
                    "FROM Enrollments AS e " +
                    "JOIN Students AS s ON e.StId = s.StId " +
                    "JOIN Courses AS c ON e.CId = c.CId " +
                    "JOIN Programs AS p ON c.ProgId = p.ProgId;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create DataAdapter
                    adapter = new SqlDataAdapter(query, connection);
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                    // Manually specify commands
                    string updateQuery = "UPDATE Enrollments SET CId = @CId WHERE StId = @Original_StId AND CId = @Original_CId";
                    adapter.UpdateCommand = new SqlCommand(updateQuery, connection);
                    adapter.UpdateCommand.Parameters.Add("@CId", SqlDbType.VarChar, 7, "CId").SourceVersion = DataRowVersion.Original;
                    adapter.UpdateCommand.Parameters.Add("@Original_StId", SqlDbType.VarChar, 10, "StId").SourceVersion = DataRowVersion.Original;
                    adapter.UpdateCommand.Parameters.Add("@Original_CId", SqlDbType.VarChar, 7, "CId").SourceVersion = DataRowVersion.Original;

                    // the insert should always set FinalGrade to NULL
                    string insertQuery = "INSERT INTO Enrollments (StId, CId, FinalGrade) VALUES (@StId, @CId, NULL)";
                    adapter.InsertCommand = new SqlCommand(insertQuery, connection);
                    adapter.InsertCommand.Parameters.Add("@StId", SqlDbType.VarChar, 10, "StId");
                    adapter.InsertCommand.Parameters.Add("@CId", SqlDbType.VarChar, 7, "CId");
                    adapter.InsertCommand.Parameters.Add("@FinalGrade", SqlDbType.Int, 0, "FinalGrade");

                    string deleteQuery = "DELETE FROM Enrollments WHERE StId = @Original_StId AND CId = @Original_CId";
                    adapter.DeleteCommand = new SqlCommand(deleteQuery, connection);
                    adapter.DeleteCommand.Parameters.Add("@Original_StId", SqlDbType.VarChar, 10, "StId").SourceVersion = DataRowVersion.Original;
                    adapter.DeleteCommand.Parameters.Add("@Original_CId", SqlDbType.VarChar, 7, "CId").SourceVersion = DataRowVersion.Original;

                    // Fill DataSet
                    ds = new DataSet();
                    adapter.Fill(ds, "Enrollments");

                    // Other initialization if needed
                    init = true;
                }
            }
            return ds.Tables["Enrollments"];
        }

        internal static void UpdateData(Enrollment originalEnrollment, Enrollment newEnrollment)
        {
            try
            {
                var line = ds.Tables["Enrollments"]
                    .AsEnumerable()
                    .Where(s => s.Field<string>("StId") == originalEnrollment.StId && s.Field<string>("CId") == originalEnrollment.CId)
                    .SingleOrDefault();
                if (line != null)
                {
                    line.SetField("StId", newEnrollment.StId);
                    line.SetField("CId", newEnrollment.CId);
                }

                // Use the adapter.Update method with the DataRow array
                adapter.Update(new DataRow[] { line });
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

        internal static void InsertData(Enrollment enrollment)
        {
            try
            {
                DataRow newRow = ds.Tables["Enrollments"].NewRow();
                newRow.SetField("StId", enrollment.StId);
                newRow.SetField("CId", enrollment.CId);
                ds.Tables["Enrollments"].Rows.Add(newRow);

                // Use the adapter.Update method with the DataRow array
                adapter.Update(new DataRow[] { newRow });
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

        internal static void DeleteData(List<Enrollment> lId)
        {
            try
            {
                foreach (Enrollment enrollment in lId)
                {
                    var line = ds.Tables["Enrollments"]
                        .AsEnumerable()
                        .Where(s => s.Field<string>("StId") == enrollment.StId && s.Field<string>("CId") == enrollment.CId)
                        .SingleOrDefault();
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

    }

    internal class Enrollment
    {
        public string StId;
        public string CId;
        public int FinalGrade;
    }
}
