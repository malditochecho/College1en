using System;
using System.Windows.Forms;
using College1en.DAL;

namespace College1en.GUI
{
    public partial class UpsertProgram : Form
    {
        internal enum Modes
        {
            INSERT,
            UPDATE
        }

        internal static UpsertProgram current;
        private Modes mode = Modes.INSERT;

        public UpsertProgram()
        {
            current = this;
            InitializeComponent();
        }

        internal void Start(Modes m, DataGridViewSelectedRowCollection collection)
        {
            mode = m;

            if (mode == Modes.INSERT)
            {
                textBoxProgramId.ReadOnly = false;
                textBoxProgramId.Text = "";
                textBoxProgramName.Text = "";
            }

            if (mode == Modes.UPDATE)
            {
                textBoxProgramId.ReadOnly = true;
                textBoxProgramId.Text = "" + collection[0].Cells["ProgId"].Value;
                textBoxProgramName.Text = "" + collection[0].Cells["ProgName"].Value;
            }

            ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            StudyProgram program = new StudyProgram();

            program.ProgId = textBoxProgramId.Text;
            program.ProgName = textBoxProgramName.Text;

            if (mode == Modes.INSERT) { Programs.InsertData(program); }
            if (mode == Modes.UPDATE) { Programs.UpdateData(program); }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
