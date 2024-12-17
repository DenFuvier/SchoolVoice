﻿using MySql.Data.MySqlClient;
using School.Classes;
using School.Windows;
using System;
using System.Windows.Forms;

namespace School
{
    public partial class Entrance : Form
    {
        SQLConnector SQL = new SQLConnector();
        public Entrance()
        {
            InitializeComponent();
            //3 обязательные строчки к каждой форме!
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaiForm_Load(object sender, EventArgs e)
        {
            

        }


        private void Entry_Click(object sender, EventArgs e)
        {
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = String.Format("SELECT Login, Password, Role FROM users WHERE Login = \"{0}\" AND password = \"{1}\"",
                    Login.Text,
                    Password.Text);
                 var cmd = new MySqlCommand(stm, con);
                 MySqlDataReader Reader = cmd.ExecuteReader();
                 if (Reader.Read())
                 {
                    string Login = Reader.GetString(0); 
                    string Password = Reader.GetString(1);  
                    string Role = Reader.GetString(2);  
                     MessageBox.Show("Успешно вошли " + " " + Login + " " + Role);


                    Users user = new Users(Login, Password, Role);
                    switch (user.Role)
                    {
                        case "Director":
                         this.Hide();
                         IntermediateFormDIR intermediateFormDIR = new IntermediateFormDIR();
                            intermediateFormDIR.ShowDialog();

                      break;


                       case "Secretary":
                            this.Hide();
                            IntermediateForSEC intermediateForSEC = new IntermediateForSEC();
                            intermediateForSEC.ShowDialog();

                       break;
                    } 

                 }

                 else
                 {
                    MessageBox.Show("Не верный пароль или логин");
                 }
               
            }
            
              catch (Exception ex)
              {
                MessageBox.Show($"Ошибка:{ex.Message}");
              }
        }

    }
}