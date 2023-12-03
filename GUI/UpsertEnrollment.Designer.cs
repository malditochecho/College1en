namespace College1en.GUI
{
    partial class UpsertEnrollment
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
            this.comboBoxStudentId = new System.Windows.Forms.ComboBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCourseId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStudentId
            // 
            this.comboBoxStudentId.FormattingEnabled = true;
            this.comboBoxStudentId.Location = new System.Drawing.Point(15, 58);
            this.comboBoxStudentId.Name = "comboBoxStudentId";
            this.comboBoxStudentId.Size = new System.Drawing.Size(143, 21);
            this.comboBoxStudentId.TabIndex = 0;
            this.comboBoxStudentId.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentId_SelectedIndexChanged);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(164, 59);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(229, 20);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student name";
            // 
            // comboBoxCourseId
            // 
            this.comboBoxCourseId.FormattingEnabled = true;
            this.comboBoxCourseId.Location = new System.Drawing.Point(15, 118);
            this.comboBoxCourseId.Name = "comboBoxCourseId";
            this.comboBoxCourseId.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCourseId.TabIndex = 4;
            this.comboBoxCourseId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course ID";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(164, 119);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(229, 20);
            this.textBoxCourseName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(85, 17);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Enrollment";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(318, 175);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 175);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UpsertEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 220);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCourseId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.comboBoxStudentId);
            this.Name = "UpsertEnrollment";
            this.Text = "Create or update enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudentId;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCourseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}