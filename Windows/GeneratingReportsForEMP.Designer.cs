namespace School.Windows
{
    partial class GeneratingReportsForEMP
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
            this.GenerateDismissalReport = new System.Windows.Forms.Button();
            this.EmployeeVIew = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RichBoard = new System.Windows.Forms.TextBox();
            this.DataYvolen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportContentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateDismissalReport
            // 
            this.GenerateDismissalReport.Location = new System.Drawing.Point(574, 287);
            this.GenerateDismissalReport.Name = "GenerateDismissalReport";
            this.GenerateDismissalReport.Size = new System.Drawing.Size(199, 23);
            this.GenerateDismissalReport.TabIndex = 0;
            this.GenerateDismissalReport.Text = "Увольнение сотрудника";
            this.GenerateDismissalReport.UseVisualStyleBackColor = true;
            this.GenerateDismissalReport.Click += new System.EventHandler(this.GenerateDismissalReport_Click);
            // 
            // EmployeeVIew
            // 
            this.EmployeeVIew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeVIew.Location = new System.Drawing.Point(12, 12);
            this.EmployeeVIew.Name = "EmployeeVIew";
            this.EmployeeVIew.Size = new System.Drawing.Size(776, 213);
            this.EmployeeVIew.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(706, 375);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Причина увольнения :";
            // 
            // RichBoard
            // 
            this.RichBoard.Location = new System.Drawing.Point(222, 291);
            this.RichBoard.Name = "RichBoard";
            this.RichBoard.Size = new System.Drawing.Size(161, 20);
            this.RichBoard.TabIndex = 4;
            // 
            // DataYvolen
            // 
            this.DataYvolen.Location = new System.Drawing.Point(198, 333);
            this.DataYvolen.Name = "DataYvolen";
            this.DataYvolen.Size = new System.Drawing.Size(164, 20);
            this.DataYvolen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата увольнения : ";
            // 
            // ReportContentLabel
            // 
            this.ReportContentLabel.AutoSize = true;
            this.ReportContentLabel.Location = new System.Drawing.Point(13, 395);
            this.ReportContentLabel.Name = "ReportContentLabel";
            this.ReportContentLabel.Size = new System.Drawing.Size(0, 13);
            this.ReportContentLabel.TabIndex = 7;
            // 
            // GeneratingReportsForEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.ReportContentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataYvolen);
            this.Controls.Add(this.RichBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EmployeeVIew);
            this.Controls.Add(this.GenerateDismissalReport);
            this.Name = "GeneratingReportsForEMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт об увольнении сотрудников";
            this.Load += new System.EventHandler(this.GeneratingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateDismissalReport;
        private System.Windows.Forms.DataGridView EmployeeVIew;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RichBoard;
        private System.Windows.Forms.TextBox DataYvolen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ReportContentLabel;
    }
}