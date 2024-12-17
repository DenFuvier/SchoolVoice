using MySql.Data.MySqlClient;
using School.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class EmployeesForms : Form
    { 
        SQLConnector SQL = new SQLConnector();
        List <Employee> employees_ = new List<Employee>();
        public EmployeesForms()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            EmployeeVIew.ReadOnly = true;
            firstNamebox.Enabled = false;
            lastNamebox.Enabled = false;
            middleNamebox.Enabled = false;
            passportNumberbox.Enabled = false;
            phoneNumberbox.Enabled = false;
            emailbox.Enabled = false;
            dateOfBirthbox.Enabled = false;
            hireDatebox.Enabled = false;
            dismissalDatebox.Enabled = false;
            positionbox.Enabled = false;
            salarybox.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var IntermediateForSEC = new IntermediateForSEC();
            IntermediateForSEC.Show();
        }

        private void EmployeesForms_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        
            private void LoadEmployeeData()
            {
                string cs = SQL.GetConnect();
                 employees_.Clear();
            try
                {
                    var con = new MySqlConnection(cs);
                    con.Open();

                    string stm = "SELECT * FROM employees";
                    var cmd = new MySqlCommand(stm, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                            int employeeId = reader.GetInt32(0); 
                            string firstName = reader.GetString(1); 
                            string lastName = reader.GetString(2);
                            string middleName = reader.GetString(3); 
                            string passportNumber = reader.GetString(4);
                            string phoneNumber = reader.GetString(5);
                            string email = reader.GetString(6); 
                            DateTime dateOfBirth = reader.GetDateTime(7); 
                            DateTime hireDate = reader.GetDateTime(8);
                            DateTime? dismissalDate = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9); 
                            string position = reader.GetString(10); 
                            int salary = reader.GetInt32(11);


                    Employee employee = new Employee(employeeId, firstName, lastName, middleName, passportNumber, phoneNumber, email, dateOfBirth, hireDate, dismissalDate, position, salary);
                    employees_.Add(employee);
                    }
                con.Close();
                EmployeeVIew.DataSource = null;
                EmployeeVIew.DataSource = employees_;
                EmployeeVIew.SelectionChanged -= EmployeeVIew_SelectionChanged;
                EmployeeVIew.SelectionChanged += EmployeeVIew_SelectionChanged; ;
                if (EmployeeVIew.Rows.Count > 0)
                {
                    EmployeeVIew.Rows[0].Selected = true;
                }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                }
            }

        private void EmployeeVIew_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeeVIew.SelectedRows.Count > 0)
            {
                int number = EmployeeVIew.SelectedRows[0].Index;

                if (number >= 0 && number < employees_.Count)
                {
                    Employee X = employees_[number];

                    employeeIdbox.Text = X.EmployeeId.ToString();
                    firstNamebox.Text = X.FirstName;
                    lastNamebox.Text = X.LastName;
                    middleNamebox.Text = X.MiddleName;
                    passportNumberbox.Text = X.PassportNumber;
                    phoneNumberbox.Text = X.PhoneNumber;
                    emailbox.Text = X.Email;
                    dateOfBirthbox.Text = X.DateOfBirth.ToString("dd.MM.yyyy");
                    hireDatebox.Text = X.HireDate.ToString("dd.MM.yyyy");
                    dismissalDatebox.Text = X.DismissalDate.HasValue ? X.DismissalDate.Value.ToString("dd.MM.yyyy") : "";
                    positionbox.Text = X.Position;
                    salarybox.Text = X.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Ошибка: Индекс строки вне диапазона.");
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (EmployeeVIew.SelectedRows.Count > 0)
            {
                int selectedIndex = EmployeeVIew.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < employees_.Count)
                {
                    int employeeId = employees_[selectedIndex].EmployeeId;

                    string firstName = firstNamebox.Text.Trim();
                    string lastName = lastNamebox.Text.Trim();
                    string middleName = middleNamebox.Text.Trim();
                    string passportNumber = passportNumberbox.Text.Trim();
                    string phoneNumber = phoneNumberbox.Text.Trim();
                    string email = emailbox.Text.Trim();

                    string dateOfBirth = DateTime.ParseExact(dateOfBirthbox.Text.Trim(), "dd.MM.yyyy", null)
                                        .ToString("yyyy-MM-dd");

                    string hireDate = DateTime.ParseExact(hireDatebox.Text.Trim(), "dd.MM.yyyy", null)
                                      .ToString("yyyy-MM-dd");

                    string dismissalDate = string.IsNullOrEmpty(dismissalDatebox.Text.Trim())
                                        ? null
                                        : DateTime.ParseExact(dismissalDatebox.Text.Trim(), "dd.MM.yyyy", null)
                                          .ToString("yyyy-MM-dd");

                    string position = positionbox.Text.Trim();

                    if (!int.TryParse(salarybox.Text.Trim(), out int salary))
                    {
                        MessageBox.Show("Ошибка: Зарплата должна быть числом.");
                        return;
                    }

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    {
                        MessageBox.Show("Поля Имя и Фамилия обязательны для заполнения.");
                        return;
                    }

                    string cs = SQL.GetConnect();

                    try
                    {
                        using (var con = new MySqlConnection(cs))
                        {
                            con.Open();

                            string stm = $"UPDATE employees SET " +
                                         $"FirstName = '{firstName}', " +
                                         $"LastName = '{lastName}', " +
                                         $"MiddleName = '{middleName}', " +
                                         $"PassportNumber = '{passportNumber}', " +
                                         $"PhoneNumber = '{phoneNumber}', " +
                                         $"Email = '{email}', " +
                                         $"DateOfBirth = '{dateOfBirth}', " +
                                         $"HireDate = '{hireDate}', " +
                                         $"DismissalDate = {(dismissalDate == null ? "NULL" : $"'{dismissalDate}'")}, " +
                                         $"Position = '{position}', " +
                                         $"Salary = {salary} " +
                                         $"WHERE EmployeeId = {employeeId}";

                            var cmd = new MySqlCommand(stm, con);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены!");

                                Employee updatedEmployee = new Employee(
                                    employeeId,
                                    firstName,
                                    lastName,
                                    middleName,
                                    passportNumber,
                                    phoneNumber,
                                    email,
                                    DateTime.Parse(dateOfBirth),
                                    DateTime.Parse(hireDate),
                                    string.IsNullOrEmpty(dismissalDate) ? (DateTime?)null : DateTime.Parse(dismissalDate),
                                    position,
                                    salary 
                                );

                                employees_[selectedIndex] = updatedEmployee;

                                EmployeeVIew.DataSource = null;
                                EmployeeVIew.DataSource = employees_;
                            }
                            else
                            {
                                MessageBox.Show("Не удалось обновить данные.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Выбран неверный индекс.");
                }
            }
        }

        private void Unlock1_Click(object sender, EventArgs e)
        {
            string inputPassword = Unlock.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputPassword))
            {
                MessageBox.Show("Введите пароль.");
                return;
            }

            SQLConnector SQL = new SQLConnector();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    string stm = $"SELECT COUNT(*) FROM users WHERE Role='Director' AND Password='{inputPassword}'";
                    var cmd = new MySqlCommand(stm, con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        firstNamebox.Enabled = true;
                        lastNamebox.Enabled = true;
                        middleNamebox.Enabled = true;
                        passportNumberbox.Enabled = true;
                        phoneNumberbox.Enabled = true;
                        emailbox.Enabled = true;
                        dateOfBirthbox.Enabled = true;
                        hireDatebox.Enabled = true;
                        dismissalDatebox.Enabled = true;
                        positionbox.Enabled = true;
                        salarybox.Enabled = true;
                        Update.Enabled = true;
                        Delete.Enabled = true;
                        Unlock.Text = "";
                        MessageBox.Show("Доступ разблокирован.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке пароля: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (EmployeeVIew.SelectedRows.Count > 0)
            {
                int selectedIndex = EmployeeVIew.SelectedRows[0].Index;
                int employeeId = employees_[selectedIndex].EmployeeId;

                string cs = SQL.GetConnect();
                try
                {
                    using (var con = new MySqlConnection(cs))
                    {
                        con.Open();

                        string stm = $"DELETE FROM employees WHERE EmployeeId = {employeeId}";
                        var cmd = new MySqlCommand(stm, con);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Сотрудник успешно удален.");

                            employees_.RemoveAt(selectedIndex);

                            EmployeeVIew.DataSource = null;
                            EmployeeVIew.DataSource = employees_;
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить сотрудника.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении данных: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Не выбран сотрудник для удаления.");
            }
        }
    }
    
}
