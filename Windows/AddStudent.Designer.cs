namespace School.Windows
{
    partial class AddStudent
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
            this.Save = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.ClassId = new System.Windows.Forms.TextBox();
            this.ParentPhoneNumber = new System.Windows.Forms.TextBox();
            this.AcademicPerformance = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.Last = new System.Windows.Forms.Label();
            this.Middle = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.Academic = new System.Windows.Forms.Label();
            this.ParentPhone = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(466, 344);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(177, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить данные о ученике";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(545, 8);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(98, 23);
            this.Clean.TabIndex = 1;
            this.Clean.Text = "Очистить поля";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(172, 33);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 20);
            this.FirstName.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(202, 74);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(198, 20);
            this.LastName.TabIndex = 3;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(213, 114);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(196, 20);
            this.MiddleName.TabIndex = 4;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(189, 149);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(208, 20);
            this.DateOfBirth.TabIndex = 5;
            // 
            // ClassId
            // 
            this.ClassId.Location = new System.Drawing.Point(237, 188);
            this.ClassId.Name = "ClassId";
            this.ClassId.Size = new System.Drawing.Size(198, 20);
            this.ClassId.TabIndex = 6;
            // 
            // ParentPhoneNumber
            // 
            this.ParentPhoneNumber.Location = new System.Drawing.Point(266, 222);
            this.ParentPhoneNumber.Name = "ParentPhoneNumber";
            this.ParentPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.ParentPhoneNumber.TabIndex = 7;
            // 
            // AcademicPerformance
            // 
            this.AcademicPerformance.Location = new System.Drawing.Point(348, 264);
            this.AcademicPerformance.Name = "AcademicPerformance";
            this.AcademicPerformance.Size = new System.Drawing.Size(197, 20);
            this.AcademicPerformance.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(154, 16);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "Введите имя ученика :";
            this.FirstNameLabel.Click += new System.EventHandler(this.Name_Click);
            // 
            // Last
            // 
            this.Last.AutoSize = true;
            this.Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Last.Location = new System.Drawing.Point(12, 74);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(184, 16);
            this.Last.TabIndex = 10;
            this.Last.Text = "Введите фамлию ученика :";
            // 
            // Middle
            // 
            this.Middle.AutoSize = true;
            this.Middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Middle.Location = new System.Drawing.Point(13, 115);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(194, 16);
            this.Middle.TabIndex = 11;
            this.Middle.Text = "Введите отчество ученика  :";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(13, 149);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(170, 16);
            this.Date.TabIndex = 12;
            this.Date.Text = "Дата рождения ученика :";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Class.Location = new System.Drawing.Point(12, 189);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(219, 16);
            this.Class.TabIndex = 13;
            this.Class.Text = "Введите номер класса ученика :";
            // 
            // Academic
            // 
            this.Academic.AutoSize = true;
            this.Academic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Academic.Location = new System.Drawing.Point(12, 265);
            this.Academic.Name = "Academic";
            this.Academic.Size = new System.Drawing.Size(330, 16);
            this.Academic.TabIndex = 14;
            this.Academic.Text = "Введите академическую успеваемость ученика :";
            // 
            // ParentPhone
            // 
            this.ParentPhone.AutoSize = true;
            this.ParentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentPhone.Location = new System.Drawing.Point(13, 222);
            this.ParentPhone.Name = "ParentPhone";
            this.ParentPhone.Size = new System.Drawing.Size(247, 16);
            this.ParentPhone.TabIndex = 14;
            this.ParentPhone.Text = "Введите номер телефона родителя :";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(3, 344);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(655, 371);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ParentPhone);
            this.Controls.Add(this.Academic);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AcademicPerformance);
            this.Controls.Add(this.ParentPhoneNumber);
            this.Controls.Add(this.ClassId);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Save);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox ClassId;
        private System.Windows.Forms.TextBox ParentPhoneNumber;
        private System.Windows.Forms.TextBox AcademicPerformance;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label Last;
        private System.Windows.Forms.Label Middle;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label Academic;
        private System.Windows.Forms.Label ParentPhone;
        private System.Windows.Forms.Button Exit;
    }
}