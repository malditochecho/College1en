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
    public partial class NewStudent : Form
    {
        internal static NewStudent current;

        public NewStudent()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start()
        {
            // fill combobox with programs
            comboBoxProgram.DataSource = Programs.GetData();
            comboBoxProgram.DisplayMember = "ProgName";
            comboBoxProgram.ValueMember = "ProgId";
            ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StId = textBoxStudentId.Text;
            student.StName = textBoxStudentName.Text;
            student.ProgId = comboBoxProgram.SelectedValue.ToString();
            Console.WriteLine(comboBoxProgram.SelectedValue.ToString());
            Students.InsertData(student);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
