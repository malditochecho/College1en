namespace College1en.GUI
{
    partial class UpdateStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.labelProgram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Enabled = false;
            this.textBoxStudentId.Location = new System.Drawing.Point(96, 51);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(103, 26);
            this.textBoxStudentId.TabIndex = 0;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(96, 97);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(331, 26);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(18, 54);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(26, 20);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "ID";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(18, 100);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(51, 20);
            this.labelStudentName.TabIndex = 3;
            this.labelStudentName.Text = "Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(350, 235);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(77, 38);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(17, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 38);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(158, 25);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Update student";
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Location = new System.Drawing.Point(96, 143);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(331, 28);
            this.comboBoxProgram.TabIndex = 18;
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Location = new System.Drawing.Point(16, 147);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(69, 20);
            this.labelProgram.TabIndex = 17;
            this.labelProgram.Text = "Program";
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 285);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.textBoxStudentId);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Label labelProgram;
    }
}