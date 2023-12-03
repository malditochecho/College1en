using System;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class FinalGrade : Form
    {
        internal static FinalGrade current;

        public FinalGrade()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(DataGridViewSelectedRowCollection collection)
        {
            textBoxStudentId.ReadOnly = true;
            textBoxStudentId.Text = collection[0].Cells["StId"].Value.ToString();
            textBoxStudentName.ReadOnly = true;
            textBoxStudentName.Text = collection[0].Cells["StName"].Value.ToString();
            textBoxCourseId.ReadOnly = true;
            textBoxCourseId.Text = collection[0].Cells["CId"].Value.ToString();
            textBoxCourseName.ReadOnly = true;
            textBoxCourseName.Text = collection[0].Cells["CName"].Value.ToString();
            textBoxFinalGrade.Text = "";

            ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // first check if the user entered an int
            // then check if the int is between 0 and 100
            int finalGrade;
            if (int.TryParse(textBoxFinalGrade.Text, out finalGrade))
            {
                if (finalGrade >= 0 && finalGrade <= 100)
                {
                    Enrollment enrollment = new Enrollment();
                    enrollment.StId = textBoxStudentId.Text;
                    enrollment.CId = textBoxCourseId.Text;
                    enrollment.FinalGrade = finalGrade;
                    Enrollments.SaveGrade(enrollment);
                    Close();
                }
                else
                {
                    MessageBox.Show("Final grade must be between 0 and 100");
                }
            }
            else
            {
                MessageBox.Show("Final grade must be an integer");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
