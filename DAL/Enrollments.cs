using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace College1en.DAL
{
    internal class Enrollments
    {
        static SqlDataAdapter adapter;
        static DataSet ds;
        static bool init = false;

        internal static DataTable GetData()
        {
            if(!init)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                string selectQuery = "SELECT DISTINCT s.StId, s.StName, c.CId, c.CName, e.FinalGrade, p.ProgId, p.ProgName\r\nFROM Enrollments AS e\r\nJOIN Students AS s\r\nON e.StId = s.StId\r\nJOIN Courses AS c\r\nON e.CId = c.CId\r\nJOIN Programs AS p\r\nON c.ProgId = p.ProgId";
                adapter = new SqlDataAdapter(selectQuery, connectionString);

                ds = new DataSet();
                adapter.Fill(ds, "Enrollments");

                init = true;
            }
            return ds.Tables["Enrollments"];
        }

        internal static void InsertData(Enrollment enrollment)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                string insertQuery = "INSERT INTO Enrollments (StId, CId, FinalGrade) VALUES (@StId, @CId, NULL)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.Add("@StId", SqlDbType.VarChar, 10).Value = enrollment.StId;
                command.Parameters.Add("@CId", SqlDbType.VarChar, 10).Value = enrollment.CId;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            ds.Clear();
            adapter.Fill(ds, "Enrollments");
            adapter.Update(ds.Tables["Enrollments"]);
        }

        internal static void UpdateData(Enrollment originalEnrollment, Enrollment newEnrollment)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                string updateQuery = "UPDATE Enrollments SET CId = @newCId WHERE StId = @StId AND CId = @oldCId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.Add("@newCId", SqlDbType.VarChar, 7).Value = newEnrollment.CId;
                command.Parameters.Add("@StId", SqlDbType.VarChar, 10).Value = originalEnrollment.StId;
                command.Parameters.Add("@oldCId", SqlDbType.VarChar, 7).Value = originalEnrollment.CId;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            ds.Clear();
            adapter.Fill(ds, "Enrollments");
            adapter.Update(ds.Tables["Enrollments"]);
        }

        internal static void DeleteData(List<Enrollment> list)
        {
            foreach (Enrollment enrollment in list)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Enrollments WHERE StId = @StId AND CId = @CId";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.Add("@StId", SqlDbType.VarChar, 10).Value = enrollment.StId;
                    command.Parameters.Add("@CId", SqlDbType.VarChar, 7).Value = enrollment.CId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            ds.Clear();
            adapter.Fill(ds, "Enrollments");
            adapter.Update(ds.Tables["Enrollments"]);
        }

    }

    internal class Enrollment
    {
        public string StId;
        public string CId;
        public int FinalGrade;
    }
}
