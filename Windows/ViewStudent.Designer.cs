namespace School.Windows
{
    partial class ViewStudent
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
            this.ViewStident = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBlock = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.ClassIdTextBox = new System.Windows.Forms.TextBox();
            this.ParentPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AcademicPerformanceTextBox = new System.Windows.Forms.TextBox();
            this.PasswordInputTextBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStident)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewStident
            // 
            this.ViewStident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewStident.Location = new System.Drawing.Point(12, 49);
            this.ViewStident.Name = "ViewStident";
            this.ViewStident.Size = new System.Drawing.Size(909, 204);
            this.ViewStident.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Списки учеников : ";
            // 
            // AddBlock
            // 
            this.AddBlock.Location = new System.Drawing.Point(731, 259);
            this.AddBlock.Name = "AddBlock";
            this.AddBlock.Size = new System.Drawing.Size(190, 23);
            this.AddBlock.TabIndex = 2;
            this.AddBlock.Text = "Разблокировать редактирование";
            this.AddBlock.UseVisualStyleBackColor = true;
            this.AddBlock.Click += new System.EventHandler(this.AddBlock_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(15, 298);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(15, 325);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(15, 352);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.MiddleNameTextBox.TabIndex = 5;
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(15, 379);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(301, 20);
            this.DateOfBirthTextBox.TabIndex = 6;
            // 
            // ClassIdTextBox
            // 
            this.ClassIdTextBox.Location = new System.Drawing.Point(15, 406);
            this.ClassIdTextBox.Name = "ClassIdTextBox";
            this.ClassIdTextBox.Size = new System.Drawing.Size(301, 20);
            this.ClassIdTextBox.TabIndex = 7;
            // 
            // ParentPhoneNumberTextBox
            // 
            this.ParentPhoneNumberTextBox.Location = new System.Drawing.Point(13, 433);
            this.ParentPhoneNumberTextBox.Name = "ParentPhoneNumberTextBox";
            this.ParentPhoneNumberTextBox.Size = new System.Drawing.Size(301, 20);
            this.ParentPhoneNumberTextBox.TabIndex = 8;
            // 
            // AcademicPerformanceTextBox
            // 
            this.AcademicPerformanceTextBox.Location = new System.Drawing.Point(15, 460);
            this.AcademicPerformanceTextBox.Name = "AcademicPerformanceTextBox";
            this.AcademicPerformanceTextBox.Size = new System.Drawing.Size(301, 20);
            this.AcademicPerformanceTextBox.TabIndex = 9;
            // 
            // PasswordInputTextBox
            // 
            this.PasswordInputTextBox.Location = new System.Drawing.Point(731, 288);
            this.PasswordInputTextBox.Name = "PasswordInputTextBox";
            this.PasswordInputTextBox.Size = new System.Drawing.Size(190, 20);
            this.PasswordInputTextBox.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(846, 481);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(357, 296);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Обновить данные";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 516);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PasswordInputTextBox);
            this.Controls.Add(this.AcademicPerformanceTextBox);
            this.Controls.Add(this.ParentPhoneNumberTextBox);
            this.Controls.Add(this.ClassIdTextBox);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AddBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewStident);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewStident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewStident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBlock;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.TextBox ClassIdTextBox;
        private System.Windows.Forms.TextBox ParentPhoneNumberTextBox;
        private System.Windows.Forms.TextBox AcademicPerformanceTextBox;
        private System.Windows.Forms.TextBox PasswordInputTextBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Update;
    }
}