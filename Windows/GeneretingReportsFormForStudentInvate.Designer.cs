namespace School.Windows
{
    partial class GeneretingReportsFormForStudentInvate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneretingReportsFormForStudentInvate));
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.DismissStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentView
            // 
            this.StudentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.StudentView, "StudentView");
            this.StudentView.Name = "StudentView";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // DismissStudent
            // 
            resources.ApplyResources(this.DismissStudent, "DismissStudent");
            this.DismissStudent.Name = "DismissStudent";
            this.DismissStudent.UseVisualStyleBackColor = true;
            this.DismissStudent.Click += new System.EventHandler(this.DismissStudent_Click);
            // 
            // GeneretingReportsFormForStudentInvate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.DismissStudent);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentView);
            this.Name = "GeneretingReportsFormForStudentInvate";
            this.Load += new System.EventHandler(this.GeneretingFormForStudentInvate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DismissStudent;
    }
}