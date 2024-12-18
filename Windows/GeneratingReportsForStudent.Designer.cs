namespace School.Windows
{
    partial class GeneratingReportsForStudent
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
            this.DismissEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataOtchislen = new System.Windows.Forms.TextBox();
            this.WhatYourСause = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DismissEmployee
            // 
            this.DismissEmployee.Location = new System.Drawing.Point(663, 360);
            this.DismissEmployee.Name = "DismissEmployee";
            this.DismissEmployee.Size = new System.Drawing.Size(125, 23);
            this.DismissEmployee.TabIndex = 2;
            this.DismissEmployee.Text = "Отчислить студента";
            this.DismissEmployee.UseVisualStyleBackColor = true;
            this.DismissEmployee.Click += new System.EventHandler(this.DismissEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата отчисления : ";
            // 
            // DataOtchislen
            // 
            this.DataOtchislen.Location = new System.Drawing.Point(202, 276);
            this.DataOtchislen.Name = "DataOtchislen";
            this.DataOtchislen.Size = new System.Drawing.Size(164, 20);
            this.DataOtchislen.TabIndex = 9;
            // 
            // WhatYourСause
            // 
            this.WhatYourСause.Location = new System.Drawing.Point(226, 233);
            this.WhatYourСause.Name = "WhatYourСause";
            this.WhatYourСause.Size = new System.Drawing.Size(161, 20);
            this.WhatYourСause.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Причина отчисления :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Список учеников :";
            // 
            // StudentView
            // 
            this.StudentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentView.Location = new System.Drawing.Point(12, 46);
            this.StudentView.Name = "StudentView";
            this.StudentView.Size = new System.Drawing.Size(776, 160);
            this.StudentView.TabIndex = 0;
            // 
            // GeneratingReportsForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataOtchislen);
            this.Controls.Add(this.WhatYourСause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DismissEmployee);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StudentView);
            this.Name = "GeneratingReportsForStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт об отчислении студентов";
            this.Load += new System.EventHandler(this.GeneratingReportsForStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DismissEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataOtchislen;
        private System.Windows.Forms.TextBox WhatYourСause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView StudentView;
    }
}