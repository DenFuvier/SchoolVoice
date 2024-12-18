namespace School.Windows
{
    partial class GeneretingReportsFormForEmploersInvate
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
            this.EmployeeVIew = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.InvateWordPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeVIew
            // 
            this.EmployeeVIew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeVIew.Location = new System.Drawing.Point(12, 61);
            this.EmployeeVIew.Name = "EmployeeVIew";
            this.EmployeeVIew.Size = new System.Drawing.Size(776, 213);
            this.EmployeeVIew.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 321);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InvateWordPrint
            // 
            this.InvateWordPrint.Location = new System.Drawing.Point(627, 292);
            this.InvateWordPrint.Name = "InvateWordPrint";
            this.InvateWordPrint.Size = new System.Drawing.Size(161, 23);
            this.InvateWordPrint.TabIndex = 2;
            this.InvateWordPrint.Text = "Отчёт о принятии на работу";
            this.InvateWordPrint.UseVisualStyleBackColor = true;
            this.InvateWordPrint.Click += new System.EventHandler(this.InvateWordPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список сотрудников :";
            // 
            // GeneretingReportsFormForEmploersInvate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvateWordPrint);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.EmployeeVIew);
            this.Name = "GeneretingReportsFormForEmploersInvate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников для отчётов";
            this.Load += new System.EventHandler(this.GeneretingFormForEmploersInvate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeVIew;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button InvateWordPrint;
        private System.Windows.Forms.Label label1;
    }
}