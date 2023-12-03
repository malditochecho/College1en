namespace College1en.GUI
{
    partial class FinalGrade
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.textBoxFinalGrade = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(65, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Final Grade";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(32, 44);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(160, 20);
            this.textBoxStudentId.TabIndex = 1;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(32, 70);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(160, 20);
            this.textBoxStudentName.TabIndex = 2;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(32, 122);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(160, 20);
            this.textBoxCourseName.TabIndex = 4;
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(32, 96);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(160, 20);
            this.textBoxCourseId.TabIndex = 3;
            // 
            // textBoxFinalGrade
            // 
            this.textBoxFinalGrade.Location = new System.Drawing.Point(88, 193);
            this.textBoxFinalGrade.Name = "textBoxFinalGrade";
            this.textBoxFinalGrade.Size = new System.Drawing.Size(49, 20);
            this.textBoxFinalGrade.TabIndex = 5;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(94, 177);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Grade";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(132, 263);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(60, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(32, 263);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(61, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FinalGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 309);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textBoxFinalGrade);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelTitle);
            this.Name = "FinalGrade";
            this.Text = "ss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.TextBox textBoxFinalGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}