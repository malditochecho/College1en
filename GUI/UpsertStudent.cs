using System;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class UpsertStudent : Form
    {
        internal enum Modes
        {
            INSERT,
            UPDATE
        }

        internal static UpsertStudent current;
        private Modes mode = Modes.INSERT;

        public UpsertStudent()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(Modes m, DataGridViewSelectedRowCollection collection)
        {
            mode = m;

            if (mode == Modes.INSERT)
            {
                textBoxStudentId.ReadOnly = false;
                textBoxStudentId.Text = "";
                textBoxStudentName.Text = "";
                comboBoxProgram.DataSource = Programs.GetData();
                comboBoxProgram.DisplayMember = "ProgName";
                comboBoxProgram.ValueMember = "ProgId";
                comboBoxProgram.SelectedValue = "";
            }

            if (mode == Modes.UPDATE)
            {
                textBoxStudentId.ReadOnly = true;
                textBoxStudentId.Text = "" + collection[0].Cells["StId"].Value;
                textBoxStudentName.Text = "" + collection[0].Cells["StName"].Value;
                comboBoxProgram.DataSource = Programs.GetData();
                comboBoxProgram.DisplayMember = "ProgName";
                comboBoxProgram.ValueMember = "ProgId";
                comboBoxProgram.SelectedValue = collection[0].Cells["ProgId"].Value;
            }

            ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.StId = textBoxStudentId.Text;
            student.StName = textBoxStudentName.Text;
            student.ProgId = comboBoxProgram.SelectedValue.ToString();

            if (mode == Modes.INSERT) { Students.InsertData(student); }
            if (mode == Modes.UPDATE) { Students.UpdateData(student); }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
