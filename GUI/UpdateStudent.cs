using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class UpdateStudent : Form
    {
        internal static UpdateStudent current;

        public UpdateStudent()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(DataGridViewSelectedRowCollection collection)
        {
            textBoxStudentId.ReadOnly = true;
            textBoxStudentId.Text = "" + collection[0].Cells["StId"].Value;
            textBoxStudentName.Text = "" + collection[0].Cells["StName"].Value;
            comboBoxProgram.DataSource = Programs.GetData();
            comboBoxProgram.DisplayMember = "ProgName";
            comboBoxProgram.ValueMember = "ProgId";
            comboBoxProgram.SelectedValue = collection[0].Cells["ProgId"].Value;
            ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StId = textBoxStudentId.Text;
            student.StName = textBoxStudentName.Text;
            student.ProgId = comboBoxProgram.SelectedValue.ToString();
            Students.UpdateData(student);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
