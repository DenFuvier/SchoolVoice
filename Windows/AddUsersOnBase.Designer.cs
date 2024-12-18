namespace School.Windows
{
    partial class AddUsersOnBase
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.UsersView = new System.Windows.Forms.DataGridView();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RoleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(12, 269);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(227, 20);
            this.LoginBox.TabIndex = 0;
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
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(392, 269);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(258, 23);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Добавить данные";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(392, 298);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(258, 23);
            this.Change.TabIndex = 3;
            this.Change.Text = "Изменить данные  выбранного пользователя";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(392, 327);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(258, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Удалить выбранного пользователя";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UsersView
            // 
            this.UsersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersView.Location = new System.Drawing.Point(2, 12);
            this.UsersView.Name = "UsersView";
            this.UsersView.Size = new System.Drawing.Size(786, 230);
            this.UsersView.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 313);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(227, 20);
            this.PasswordBox.TabIndex = 6;
            // 
            // RoleBox
            // 
            this.RoleBox.Location = new System.Drawing.Point(12, 358);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(227, 20);
            this.RoleBox.TabIndex = 7;
            // 
            // AddUsersOnBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsersView);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginBox);
            this.Name = "AddUsersOnBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новых пользователей";
            this.Load += new System.EventHandler(this.AddUsersOnBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView UsersView;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox RoleBox;
    }
}