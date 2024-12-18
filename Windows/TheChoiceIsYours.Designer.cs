namespace School.Windows
{
    partial class TheChoiceIsYours
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
            this.DeleteEmployer = new System.Windows.Forms.Button();
            this.OpenFormDeleteStudent = new System.Windows.Forms.Button();
            this.openIvanteStudent = new System.Windows.Forms.Button();
            this.openIvanteNPC = new System.Windows.Forms.Button();
            this.LoadStudentAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(11, 180);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeleteEmployer
            // 
            this.DeleteEmployer.Location = new System.Drawing.Point(11, 12);
            this.DeleteEmployer.Name = "DeleteEmployer";
            this.DeleteEmployer.Size = new System.Drawing.Size(143, 23);
            this.DeleteEmployer.TabIndex = 1;
            this.DeleteEmployer.Text = "Увольнение сотрудника";
            this.DeleteEmployer.UseVisualStyleBackColor = true;
            this.DeleteEmployer.Click += new System.EventHandler(this.DeleteEmployer_Click);
            // 
            // OpenFormDeleteStudent
            // 
            this.OpenFormDeleteStudent.Location = new System.Drawing.Point(11, 41);
            this.OpenFormDeleteStudent.Name = "OpenFormDeleteStudent";
            this.OpenFormDeleteStudent.Size = new System.Drawing.Size(143, 23);
            this.OpenFormDeleteStudent.TabIndex = 2;
            this.OpenFormDeleteStudent.Text = "Отчисление студентов";
            this.OpenFormDeleteStudent.UseVisualStyleBackColor = true;
            this.OpenFormDeleteStudent.Click += new System.EventHandler(this.OpenFormDeleteStudent_Click);
            // 
            // openIvanteStudent
            // 
            this.openIvanteStudent.Location = new System.Drawing.Point(11, 68);
            this.openIvanteStudent.Name = "openIvanteStudent";
            this.openIvanteStudent.Size = new System.Drawing.Size(143, 23);
            this.openIvanteStudent.TabIndex = 3;
            this.openIvanteStudent.Text = "Приказ о зачислении";
            this.openIvanteStudent.UseVisualStyleBackColor = true;
            this.openIvanteStudent.Click += new System.EventHandler(this.openIvanteStudent_Click);
            // 
            // openIvanteNPC
            // 
            this.openIvanteNPC.Location = new System.Drawing.Point(11, 97);
            this.openIvanteNPC.Name = "openIvanteNPC";
            this.openIvanteNPC.Size = new System.Drawing.Size(143, 23);
            this.openIvanteNPC.TabIndex = 4;
            this.openIvanteNPC.Text = "Приказ о принятии";
            this.openIvanteNPC.UseVisualStyleBackColor = true;
            this.openIvanteNPC.Click += new System.EventHandler(this.openIvanteNPC_Click);
            // 
            // LoadStudentAll
            // 
            this.LoadStudentAll.Location = new System.Drawing.Point(11, 126);
            this.LoadStudentAll.Name = "LoadStudentAll";
            this.LoadStudentAll.Size = new System.Drawing.Size(143, 23);
            this.LoadStudentAll.TabIndex = 5;
            this.LoadStudentAll.Text = "Кол-во и данные";
            this.LoadStudentAll.UseVisualStyleBackColor = true;
            this.LoadStudentAll.Click += new System.EventHandler(this.LoadStudentAll_Click);
            // 
            // TheChoiceIsYours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(216, 207);
            this.Controls.Add(this.LoadStudentAll);
            this.Controls.Add(this.openIvanteNPC);
            this.Controls.Add(this.openIvanteStudent);
            this.Controls.Add(this.OpenFormDeleteStudent);
            this.Controls.Add(this.DeleteEmployer);
            this.Controls.Add(this.Exit);
            this.Name = "TheChoiceIsYours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор : ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DeleteEmployer;
        private System.Windows.Forms.Button OpenFormDeleteStudent;
        private System.Windows.Forms.Button openIvanteStudent;
        private System.Windows.Forms.Button openIvanteNPC;
        private System.Windows.Forms.Button LoadStudentAll;
    }
}