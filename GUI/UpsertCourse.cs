﻿using System;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class UpsertCourse : Form
    {
        internal enum Modes
        {
            INSERT,
            UPDATE
        }

        internal static UpsertCourse current;
        private Modes mode = Modes.INSERT;

        public UpsertCourse()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(Modes m, DataGridViewSelectedRowCollection collection)
        {
            mode = m;

            if (mode == Modes.INSERT)
            {
                textBoxCourseId.ReadOnly = false;
                textBoxCourseId.Text = "";
                textBoxCourseName.Text = "";
                comboBoxProgram.DataSource = Programs.GetData();
                comboBoxProgram.DisplayMember = "ProgName";
                comboBoxProgram.ValueMember = "ProgId";
                comboBoxProgram.SelectedValue = "";
            }

            if (mode == Modes.UPDATE)
            {
                textBoxCourseId.ReadOnly = true;
                textBoxCourseId.Text = "" + collection[0].Cells["CId"].Value;
                textBoxCourseName.Text = "" + collection[0].Cells["CName"].Value;
                comboBoxProgram.DataSource = Programs.GetData();
                comboBoxProgram.DisplayMember = "ProgName";
                comboBoxProgram.ValueMember = "ProgId";
                comboBoxProgram.SelectedValue = collection[0].Cells["ProgId"].Value;
            }

            ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            course.CId = textBoxCourseId.Text;
            course.CName = textBoxCourseName.Text;
            course.ProgId = comboBoxProgram.SelectedValue.ToString();

            if (mode == Modes.INSERT) { Courses.InsertData(course); }
            if (mode == Modes.UPDATE) { Courses.UpdateData(course); }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
