using MySql.Data.MySqlClient;
using School.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class AddUsersOnBase : Form
    {
        List<Users> users_ = new List<Users>();
        SQLConnector SQL = new SQLConnector();
        public AddUsersOnBase()
        {
            InitializeComponent();
            UsersView.ReadOnly = true;
        }
        private void Loadusers()
        {
            SQLConnector SQL = new SQLConnector();
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT UserId , Login , Password , Role FROM users";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    int UserId = Reader.GetInt32(0);
                    string Login = Reader.GetString(1);
                    string Password = Reader.GetString(2);
                    string Role = Reader.GetString(3);
                    Users use = new Users(UserId, Login, Password, Role);
                    users_.Add(use);
                }
                con.Close();
                users_.Add(new Users(0, "", "", ""));
                UsersView.DataSource = null;
                UsersView.DataSource = users_;
                UsersView.SelectionChanged += UsersView_SelectionChanged;
                if (UsersView.Rows.Count > 0)
                {
                    UsersView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}");
            }

        }
        private void AddUsersOnBase_Load(object sender, EventArgs e)
        {
            Loadusers();
        }

        private void UsersView_SelectionChanged(object sender, EventArgs e)
        {
            if (UsersView.SelectedRows.Count > 0)
            {
                int number = UsersView.SelectedRows[0].Index;

                if (number >= 0 && number < users_.Count)
                {
                    Users X = users_[number];
                    LoginBox.Text = X.Login;
                    PasswordBox.Text = X.Password;
                    RoleBox.Text = X.Role;
                }
                else
                {
                    MessageBox.Show("Ошибка: Индекс строки вне диапазона.");
                }
            }
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            var IntermediateFormDIR = new IntermediateFormDIR();
            IntermediateFormDIR.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text.Trim();
            string password = PasswordBox.Text.Trim();
            string role = RoleBox.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = String.Format(
                    "INSERT INTO users (Login, Password, Role) VALUES ('{0}', '{1}', '{2}')",
                    login, password, role);
                var cmd = new MySqlCommand(stm, con);
                cmd.ExecuteNonQuery();
                Users newUser = new Users(0, login, password, role);
                users_.Add(newUser);
                UsersView.DataSource = null;
                UsersView.DataSource = users_;
                MessageBox.Show("Новая запись успешно добавлена!");
                LoginBox.Clear();
                PasswordBox.Clear();
                RoleBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (UsersView.SelectedRows.Count > 0)
            {
                int selectedIndex = UsersView.SelectedRows[0].Index;
                int userId = users_[selectedIndex].UserId;
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cs = SQL.GetConnect();
                    try
                    {
                        using (var con = new MySqlConnection(cs))
                        {
                            con.Open();
                            string stm = $"DELETE FROM users WHERE UserId = {userId}";
                            var cmd = new MySqlCommand(stm, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Пользователь успешно удален!");
                            users_.RemoveAt(selectedIndex);
                            UsersView.DataSource = null;
                            UsersView.DataSource = users_;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (UsersView.SelectedRows.Count > 0)
            {
                int selectedIndex = UsersView.SelectedRows[0].Index;
                int userId = users_[selectedIndex].UserId;
                string newLogin = LoginBox.Text.Trim();
                string newPassword = PasswordBox.Text.Trim();
                string newRole = RoleBox.Text.Trim();
                if (string.IsNullOrEmpty(newLogin) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newRole))
                {
                    MessageBox.Show("Все поля должны быть заполнены.");
                    return;
                }
                var result = MessageBox.Show("Вы уверены, что хотите изменить данные этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string cs = SQL.GetConnect();
                    try
                    {
                        using (var con = new MySqlConnection(cs))
                        {
                            con.Open();
                            string stm = $"UPDATE users SET Login = '{newLogin}', Password = '{newPassword}', Role = '{newRole}' WHERE UserId = {userId}";
                            var cmd = new MySqlCommand(stm, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Данные пользователя успешно обновлены!");
                            users_[selectedIndex].Login = newLogin;
                            users_[selectedIndex].Password = newPassword;
                            users_[selectedIndex].Role = newRole;
                            UsersView.DataSource = null;
                            UsersView.DataSource = users_;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении данных пользователя: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для изменения.");
            }
        }
    }
    
}
