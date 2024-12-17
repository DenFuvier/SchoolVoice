namespace School.Windows
{
    partial class IntermediateFormDIR
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
            this.OpenUsersForm = new System.Windows.Forms.Button();
            this.OpenGemerericForm = new System.Windows.Forms.Button();
            this.ADDEXX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 140);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OpenUsersForm
            // 
            this.OpenUsersForm.Location = new System.Drawing.Point(19, 11);
            this.OpenUsersForm.Name = "OpenUsersForm";
            this.OpenUsersForm.Size = new System.Drawing.Size(153, 23);
            this.OpenUsersForm.TabIndex = 1;
            this.OpenUsersForm.Text = "Добавление пользователя";
            this.OpenUsersForm.UseVisualStyleBackColor = true;
            this.OpenUsersForm.Click += new System.EventHandler(this.OpenUsersForm_Click);
            // 
            // OpenGemerericForm
            // 
            this.OpenGemerericForm.Location = new System.Drawing.Point(19, 40);
            this.OpenGemerericForm.Name = "OpenGemerericForm";
            this.OpenGemerericForm.Size = new System.Drawing.Size(153, 23);
            this.OpenGemerericForm.TabIndex = 2;
            this.OpenGemerericForm.Text = "Сгенерировать отчёт";
            this.OpenGemerericForm.UseVisualStyleBackColor = true;
            this.OpenGemerericForm.Click += new System.EventHandler(this.OpenGemerericForm_Click);
            // 
            // ADDEXX
            // 
            this.ADDEXX.Location = new System.Drawing.Point(19, 69);
            this.ADDEXX.Name = "ADDEXX";
            this.ADDEXX.Size = new System.Drawing.Size(153, 23);
            this.ADDEXX.TabIndex = 4;
            this.ADDEXX.Text = "Добавить сотрудника";
            this.ADDEXX.UseVisualStyleBackColor = true;
            this.ADDEXX.Click += new System.EventHandler(this.ADDEXX_Click);
            // 
            // IntermediateFormDIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(189, 171);
            this.Controls.Add(this.ADDEXX);
            this.Controls.Add(this.OpenGemerericForm);
            this.Controls.Add(this.OpenUsersForm);
            this.Controls.Add(this.Exit);
            this.Name = "IntermediateFormDIR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Директор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button OpenUsersForm;
        private System.Windows.Forms.Button OpenGemerericForm;
        private System.Windows.Forms.Button ADDEXX;
    }
}