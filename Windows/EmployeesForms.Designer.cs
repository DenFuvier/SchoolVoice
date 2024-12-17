namespace School.Windows
{
    partial class EmployeesForms
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
            this.employeeIdbox = new System.Windows.Forms.TextBox();
            this.firstNamebox = new System.Windows.Forms.TextBox();
            this.lastNamebox = new System.Windows.Forms.TextBox();
            this.middleNamebox = new System.Windows.Forms.TextBox();
            this.passportNumberbox = new System.Windows.Forms.TextBox();
            this.phoneNumberbox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.dateOfBirthbox = new System.Windows.Forms.TextBox();
            this.hireDatebox = new System.Windows.Forms.TextBox();
            this.dismissalDatebox = new System.Windows.Forms.TextBox();
            this.positionbox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.salarybox = new System.Windows.Forms.TextBox();
            this.Unlock = new System.Windows.Forms.TextBox();
            this.Unlock1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeVIew
            // 
            this.EmployeeVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeVIew.Location = new System.Drawing.Point(12, 42);
            this.EmployeeVIew.Name = "EmployeeVIew";
            this.EmployeeVIew.Size = new System.Drawing.Size(776, 205);
            this.EmployeeVIew.TabIndex = 0;
            // 
            // employeeIdbox
            // 
            this.employeeIdbox.Location = new System.Drawing.Point(11, 253);
            this.employeeIdbox.Name = "employeeIdbox";
            this.employeeIdbox.Size = new System.Drawing.Size(100, 20);
            this.employeeIdbox.TabIndex = 1;
            // 
            // firstNamebox
            // 
            this.firstNamebox.Location = new System.Drawing.Point(12, 280);
            this.firstNamebox.Name = "firstNamebox";
            this.firstNamebox.Size = new System.Drawing.Size(100, 20);
            this.firstNamebox.TabIndex = 2;
            // 
            // lastNamebox
            // 
            this.lastNamebox.Location = new System.Drawing.Point(12, 307);
            this.lastNamebox.Name = "lastNamebox";
            this.lastNamebox.Size = new System.Drawing.Size(100, 20);
            this.lastNamebox.TabIndex = 3;
            // 
            // middleNamebox
            // 
            this.middleNamebox.Location = new System.Drawing.Point(12, 334);
            this.middleNamebox.Name = "middleNamebox";
            this.middleNamebox.Size = new System.Drawing.Size(100, 20);
            this.middleNamebox.TabIndex = 4;
            // 
            // passportNumberbox
            // 
            this.passportNumberbox.Location = new System.Drawing.Point(12, 361);
            this.passportNumberbox.Name = "passportNumberbox";
            this.passportNumberbox.Size = new System.Drawing.Size(100, 20);
            this.passportNumberbox.TabIndex = 5;
            // 
            // phoneNumberbox
            // 
            this.phoneNumberbox.Location = new System.Drawing.Point(12, 388);
            this.phoneNumberbox.Name = "phoneNumberbox";
            this.phoneNumberbox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberbox.TabIndex = 6;
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(12, 415);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(100, 20);
            this.emailbox.TabIndex = 7;
            // 
            // dateOfBirthbox
            // 
            this.dateOfBirthbox.Location = new System.Drawing.Point(118, 253);
            this.dateOfBirthbox.Name = "dateOfBirthbox";
            this.dateOfBirthbox.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthbox.TabIndex = 8;
            // 
            // hireDatebox
            // 
            this.hireDatebox.Location = new System.Drawing.Point(118, 280);
            this.hireDatebox.Name = "hireDatebox";
            this.hireDatebox.Size = new System.Drawing.Size(100, 20);
            this.hireDatebox.TabIndex = 9;
            // 
            // dismissalDatebox
            // 
            this.dismissalDatebox.Location = new System.Drawing.Point(119, 306);
            this.dismissalDatebox.Name = "dismissalDatebox";
            this.dismissalDatebox.Size = new System.Drawing.Size(100, 20);
            this.dismissalDatebox.TabIndex = 10;
            // 
            // positionbox
            // 
            this.positionbox.Location = new System.Drawing.Point(119, 333);
            this.positionbox.Name = "positionbox";
            this.positionbox.Size = new System.Drawing.Size(100, 20);
            this.positionbox.TabIndex = 11;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Списки сотрудников";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(289, 277);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 14;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(289, 317);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // salarybox
            // 
            this.salarybox.Location = new System.Drawing.Point(118, 359);
            this.salarybox.Name = "salarybox";
            this.salarybox.Size = new System.Drawing.Size(100, 20);
            this.salarybox.TabIndex = 16;
            // 
            // Unlock
            // 
            this.Unlock.Location = new System.Drawing.Point(658, 293);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(130, 20);
            this.Unlock.TabIndex = 17;
            // 
            // Unlock1
            // 
            this.Unlock1.Location = new System.Drawing.Point(658, 264);
            this.Unlock1.Name = "Unlock1";
            this.Unlock1.Size = new System.Drawing.Size(130, 23);
            this.Unlock1.TabIndex = 18;
            this.Unlock1.Text = "Разблокировать";
            this.Unlock1.UseVisualStyleBackColor = true;
            this.Unlock1.Click += new System.EventHandler(this.Unlock1_Click);
            // 
            // EmployeesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Unlock1);
            this.Controls.Add(this.Unlock);
            this.Controls.Add(this.salarybox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.positionbox);
            this.Controls.Add(this.dismissalDatebox);
            this.Controls.Add(this.hireDatebox);
            this.Controls.Add(this.dateOfBirthbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.phoneNumberbox);
            this.Controls.Add(this.passportNumberbox);
            this.Controls.Add(this.middleNamebox);
            this.Controls.Add(this.lastNamebox);
            this.Controls.Add(this.firstNamebox);
            this.Controls.Add(this.employeeIdbox);
            this.Controls.Add(this.EmployeeVIew);
            this.Name = "EmployeesForms";
            this.Text = "employees";
            this.Load += new System.EventHandler(this.EmployeesForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeVIew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeVIew;
        private System.Windows.Forms.TextBox employeeIdbox;
        private System.Windows.Forms.TextBox firstNamebox;
        private System.Windows.Forms.TextBox lastNamebox;
        private System.Windows.Forms.TextBox middleNamebox;
        private System.Windows.Forms.TextBox passportNumberbox;
        private System.Windows.Forms.TextBox phoneNumberbox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox dateOfBirthbox;
        private System.Windows.Forms.TextBox hireDatebox;
        private System.Windows.Forms.TextBox dismissalDatebox;
        private System.Windows.Forms.TextBox positionbox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox salarybox;
        private System.Windows.Forms.TextBox Unlock;
        private System.Windows.Forms.Button Unlock1;
    }
}