using System;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class UpsertEnrollment : Form
    {
        internal enum Modes
        {
            INSERT,
            UPDATE
        }

        internal static UpsertEnrollment current;
        private Modes mode = Modes.INSERT;
        private Enrollment originalEnrollment = new Enrollment();

        public UpsertEnrollment()
        {
            current = this;
            InitializeComponent();

            // Attach the event handler to the SelectedIndexChanged event of comboBoxStudentId
            comboBoxStudentId.SelectedIndexChanged += comboBoxStudentId_SelectedIndexChanged;
            comboBoxCourseId.SelectedIndexChanged += comboBoxCourseId_SelectedIndexChanged;
        }

        internal void Start(Modes m, DataGridViewSelectedRowCollection collection)
        {
            mode = m;

            if (mode == Modes.INSERT)
            {
                comboBoxStudentId.Enabled = true;
                comboBoxStudentId.DataSource = Students.GetData();
                comboBoxStudentId.DisplayMember = "StId";
                comboBoxStudentId.ValueMember = "StName";
                comboBoxStudentId.SelectedValue = "";

                textBoxStudentName.ReadOnly = true;
                textBoxStudentName.Text = "";

                comboBoxCourseId.Enabled = true;
                comboBoxCourseId.DataSource = Courses.GetData();
                comboBoxCourseId.DisplayMember = "CId";
                comboBoxCourseId.ValueMember = "CName";
                comboBoxCourseId.SelectedValue = "";

                textBoxCourseName.ReadOnly = true;
                textBoxCourseName.Text = "";
            }

            if (mode == Modes.UPDATE)
            {
                comboBoxStudentId.Enabled = false;
                comboBoxStudentId.DataSource = Students.GetData();
                comboBoxStudentId.DisplayMember = "StId";
                comboBoxStudentId.ValueMember = "StName";
                comboBoxStudentId.SelectedValue = collection[0].Cells["StName"].Value;

                textBoxStudentName.ReadOnly = true;
                textBoxStudentName.Text = collection[0].Cells["StName"].Value.ToString();

                comboBoxCourseId.DataSource = Courses.GetData();
                comboBoxCourseId.DisplayMember = "CId";
                comboBoxCourseId.ValueMember = "CName";
                comboBoxCourseId.SelectedValue = collection[0].Cells["CName"].Value;

                textBoxCourseName.ReadOnly = true;
                textBoxCourseName.Text = collection[0].Cells["CName"].Value.ToString();

                // information about the original enrollment and the modified one
                originalEnrollment.StId = collection[0].Cells["StId"].Value.ToString();
                originalEnrollment.CId = comboBoxCourseId.Text.ToString();
            }

            ShowDialog();
        }

        private void comboBoxStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected value from comboBoxStudentId
            string selectedStudentId = comboBoxStudentId.SelectedValue?.ToString();

            // Set the text of textBoxStudentName based on the selected value
            textBoxStudentName.Text = selectedStudentId;
        }

        private void comboBoxCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourseId = comboBoxCourseId.SelectedValue?.ToString();
            textBoxCourseName.Text = selectedCourseId;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Enrollment newEnrollment = new Enrollment();


            newEnrollment.StId = comboBoxStudentId.Text;
            newEnrollment.CId = comboBoxCourseId.Text;

            if (mode == Modes.INSERT) { Enrollments.InsertData(newEnrollment); }
            if (mode == Modes.UPDATE) { Enrollments.UpdateData(originalEnrollment, newEnrollment); }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
