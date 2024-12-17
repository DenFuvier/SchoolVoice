namespace School.Windows
{
    partial class IntermediateForSEC
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
            this.Exit = new System.Windows.Forms.Button();
            this.EnterData = new System.Windows.Forms.Button();
            this.ViewData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 111);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // EnterData
            // 
            this.EnterData.Location = new System.Drawing.Point(12, 12);
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(111, 23);
            this.EnterData.TabIndex = 1;
            this.EnterData.Text = "Внести данные";
            this.EnterData.UseVisualStyleBackColor = true;
            this.EnterData.Click += new System.EventHandler(this.EnterData_Click);
            // 
            // ViewData
            // 
            this.ViewData.Location = new System.Drawing.Point(12, 41);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(111, 23);
            this.ViewData.TabIndex = 2;
            this.ViewData.Text = "Просмотр списка учеников ";
            this.ViewData.UseVisualStyleBackColor = true;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
            // 
            // IntermediateForSEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 142);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.EnterData);
            this.Controls.Add(this.Exit);
            this.Name = "IntermediateForSEC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntermediateForSEC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EnterData;
        private System.Windows.Forms.Button ViewData;
    }
}