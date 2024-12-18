namespace School.Windows
{
    partial class GeneretingReportsFormKolVoANDdannie
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
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.KolvoNPC = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PersonalLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(204, 23);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Количество студентов ";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // KolvoNPC
            // 
            this.KolvoNPC.Location = new System.Drawing.Point(12, 41);
            this.KolvoNPC.Name = "KolvoNPC";
            this.KolvoNPC.Size = new System.Drawing.Size(204, 23);
            this.KolvoNPC.TabIndex = 1;
            this.KolvoNPC.Text = "Количество сотрудников";
            this.KolvoNPC.UseVisualStyleBackColor = true;
            this.KolvoNPC.Click += new System.EventHandler(this.KolvoNPC_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 156);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PersonalLoad
            // 
            this.PersonalLoad.Location = new System.Drawing.Point(13, 71);
            this.PersonalLoad.Name = "PersonalLoad";
            this.PersonalLoad.Size = new System.Drawing.Size(203, 23);
            this.PersonalLoad.TabIndex = 3;
            this.PersonalLoad.Text = "Персональные данные сотрудников";
            this.PersonalLoad.UseVisualStyleBackColor = true;
            this.PersonalLoad.Click += new System.EventHandler(this.PersonalLoad_Click);
            // 
            // GeneretingReportsFormKolVoANDdannie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(224, 191);
            this.Controls.Add(this.PersonalLoad);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.KolvoNPC);
            this.Controls.Add(this.GenerateReportButton);
            this.Name = "GeneretingReportsFormKolVoANDdannie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор :";
            this.Load += new System.EventHandler(this.GeneretingReportsFormKolVoStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button KolvoNPC;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button PersonalLoad;
    }
}