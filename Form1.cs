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

namespace College1en
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.GetData();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Courses.GetData();
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Programs.GetData();
        }
    }
}
