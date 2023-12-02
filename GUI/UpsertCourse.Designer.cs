namespace College1en.GUI
{
    partial class UpsertCourse
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
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.labelProgram = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Location = new System.Drawing.Point(64, 93);
            this.comboBoxProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(222, 21);
            this.comboBoxProgram.TabIndex = 27;
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Location = new System.Drawing.Point(11, 96);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(46, 13);
            this.labelProgram.TabIndex = 26;
            this.labelProgram.Text = "Program";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(11, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 17);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Course";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(5, 153);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(57, 25);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(233, 153);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(51, 25);
            this.buttonOk.TabIndex = 23;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(12, 65);
            this.labelCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(35, 13);
            this.labelCourseName.TabIndex = 22;
            this.labelCourseName.Text = "Name";
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Location = new System.Drawing.Point(12, 35);
            this.labelCourseId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(18, 13);
            this.labelCourseId.TabIndex = 21;
            this.labelCourseId.Text = "ID";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(64, 63);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(222, 20);
            this.textBoxCourseName.TabIndex = 20;
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(64, 33);
            this.textBoxCourseId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(70, 20);
            this.textBoxCourseId.TabIndex = 19;
            // 
            // UpsertCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 183);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpsertCourse";
            this.Text = "UpsertCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseId;
    }
}