namespace College1en.GUI
{
    partial class UpsertProgram
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.labelProgramId = new System.Windows.Forms.Label();
            this.textBoxProgramName = new System.Windows.Forms.TextBox();
            this.textBoxProgramId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(93, 25);
            this.labelTitle.TabIndex = 34;
            this.labelTitle.Text = "Program";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(17, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 38);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(356, 179);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(77, 38);
            this.buttonOk.TabIndex = 32;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Location = new System.Drawing.Point(18, 100);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(51, 20);
            this.labelProgramName.TabIndex = 31;
            this.labelProgramName.Text = "Name";
            // 
            // labelProgramId
            // 
            this.labelProgramId.AutoSize = true;
            this.labelProgramId.Location = new System.Drawing.Point(18, 54);
            this.labelProgramId.Name = "labelProgramId";
            this.labelProgramId.Size = new System.Drawing.Size(26, 20);
            this.labelProgramId.TabIndex = 30;
            this.labelProgramId.Text = "ID";
            // 
            // textBoxProgramName
            // 
            this.textBoxProgramName.Location = new System.Drawing.Point(96, 97);
            this.textBoxProgramName.Name = "textBoxProgramName";
            this.textBoxProgramName.Size = new System.Drawing.Size(337, 26);
            this.textBoxProgramName.TabIndex = 29;
            // 
            // textBoxProgramId
            // 
            this.textBoxProgramId.Location = new System.Drawing.Point(96, 51);
            this.textBoxProgramId.Name = "textBoxProgramId";
            this.textBoxProgramId.Size = new System.Drawing.Size(103, 26);
            this.textBoxProgramId.TabIndex = 28;
            // 
            // UpsertProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 229);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelProgramName);
            this.Controls.Add(this.labelProgramId);
            this.Controls.Add(this.textBoxProgramName);
            this.Controls.Add(this.textBoxProgramId);
            this.Name = "UpsertProgram";
            this.Text = "UpsertProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Label labelProgramId;
        private System.Windows.Forms.TextBox textBoxProgramName;
        private System.Windows.Forms.TextBox textBoxProgramId;
    }
}