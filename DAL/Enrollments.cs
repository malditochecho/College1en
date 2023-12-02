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
                string query = "SELECT DISTINCT s.StId, s.StName, c.CId, c.CName, e.FinalGrade, p.ProgId, p.ProgName " +
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
                    adapter.UpdateCommand = new SqlCommand(
                        "UPDATE Enrollments SET FinalGrade = @FinalGrade WHERE StId = @Original_StId AND CId = @Original_CId", connection);
                    adapter.UpdateCommand.Parameters.Add("@FinalGrade", SqlDbType.Int, 0, "FinalGrade");
                    adapter.UpdateCommand.Parameters.Add("@Original_StId", SqlDbType.VarChar, 10, "StId").SourceVersion = DataRowVersion.Original;
                    adapter.UpdateCommand.Parameters.Add("@Original_CId", SqlDbType.VarChar, 7, "CId").SourceVersion = DataRowVersion.Original;

                    adapter.InsertCommand = new SqlCommand(
                        "INSERT INTO Enrollments (StId, CId, FinalGrade) VALUES (@StId, @CId, @FinalGrade)", connection);
                    adapter.InsertCommand.Parameters.Add("@StId", SqlDbType.VarChar, 10, "StId");
                    adapter.InsertCommand.Parameters.Add("@CId", SqlDbType.VarChar, 7, "CId");
                    adapter.InsertCommand.Parameters.Add("@FinalGrade", SqlDbType.Int, 0, "FinalGrade");

                    adapter.DeleteCommand = new SqlCommand(
                        "DELETE FROM Enrollments WHERE StId = @Original_StId AND CId = @Original_CId", connection);
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
    }
}
