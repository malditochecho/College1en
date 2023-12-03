using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using College1en.DAL;
using College1en.GUI;

namespace College1en
{
    public partial class Home : Form
    {
        internal static Home current;

        public Home()
        {
            current = this;
            InitializeComponent();
        }

        // WHEN HOME FORM LOADS
        private void Form1_Load(object sender, EventArgs e)
        {
            new UpsertEnrollment();
            new UpsertStudent();
            new UpsertCourse();
            new UpsertProgram();
            new FinalGrade();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        // STUDENTS MANAGEMENT
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.GetData();
        }

        private void insertToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpsertStudent.current.Start(UpsertStudent.Modes.INSERT, null);
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("A line must be selected for update");
            }
            else if (collection.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else // only 1 selected
            {
                UpsertStudent.current.Start(UpsertStudent.Modes.UPDATE, collection);
            }
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection col = dataGridView1.SelectedRows;
            if (col.Count == 0)
            {
                MessageBox.Show("At least one line must be selected for deletion");
            }
            else // 1 or more selected
            {
                List<string> lId = new List<string>();
                for (int i = 0; i < col.Count; i++)
                {
                    lId.Add((string)col[i].Cells["StId"].Value);
                }
                Students.DeleteData(lId);
            }
        }

        // COURSES MANAGEMENT
        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Courses.GetData();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpsertCourse.current.Start(UpsertCourse.Modes.INSERT, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("A line must be selected for update");
            }
            else if (collection.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else // only 1 selected
            {
                UpsertCourse.current.Start(UpsertCourse.Modes.UPDATE, collection);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("At least one line must be selected for deletion");
            }
            else // 1 or more selected
            {
                List<string> lId = new List<string>();
                for (int i = 0; i < collection.Count; i++)
                {
                    lId.Add((string)collection[i].Cells["CId"].Value);
                }
                Courses.DeleteData(lId);
            }
        }


        // PROGRAMS MANAGEMENT
        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Programs.GetData();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpsertProgram.current.Start(UpsertProgram.Modes.INSERT, null);
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("A line must be selected for update");
            }
            else if (collection.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else // only 1 selected
            {
                UpsertProgram.current.Start(UpsertProgram.Modes.UPDATE, collection);
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("At least one line must be selected for deletion");
            }
            else // 1 or more selected
            {
                List<string> lId = new List<string>();
                for (int i = 0; i < collection.Count; i++)
                {
                    lId.Add((string)collection[i].Cells["ProgId"].Value);
                }
                Programs.DeleteData(lId);
            }
        }

        // ENROLLMENTS MANAGEMENT
        private void enrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Enrollments.GetData();
        }

        private void addStripMenuItem_Click(object sender, EventArgs e)
        {
            UpsertEnrollment.current.Start(UpsertEnrollment.Modes.INSERT, null);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("A line must be selected for update");
            }
            else if (collection.Count > 1)
            {
                MessageBox.Show("Only one line must be selected for update");
            }
            else // only 1 selected
            {
                UpsertEnrollment.current.Start(UpsertEnrollment.Modes.UPDATE, collection);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("At least one line must be selected for deletion");
            }
            else // 1 or more selected
            {
                List<Enrollment> lId = new List<Enrollment>();
                foreach (DataGridViewRow row in collection)
                {
                    Enrollment enrollment = new Enrollment();
                    enrollment.StId = row.Cells["StId"].Value.ToString();
                    enrollment.CId = row.Cells["CId"].Value.ToString();
                    lId.Add(enrollment);
                }
                Enrollments.DeleteData(lId);
            }
        }

        private void manageFinalGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            if (collection.Count == 0)
            {
                MessageBox.Show("At least one line must be selected");
            }
            else if (collection.Count > 1)
            {
                MessageBox.Show("Only one line must be selected");
            }
            else // only 1 selected
            {
                FinalGrade.current.Start(collection);
            }
        }

        // OTHERS
        internal static void UIMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
