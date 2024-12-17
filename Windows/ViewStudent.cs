using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using School.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class ViewStudent : Form
    {
        List<Student> student_ = new List<Student>();

        public ViewStudent()
        {
            InitializeComponent();
            ViewStident.ReadOnly = true;
            FirstNameTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;
            MiddleNameTextBox.Enabled = false;
            DateOfBirthTextBox.Enabled = false;
            ClassIdTextBox.Enabled  = false;
            ParentPhoneNumberTextBox.Enabled = false;
            AcademicPerformanceTextBox.Enabled = false;
            Update.Enabled = false;
        }

        private void ViewStident_SelectionChanged(object sender, EventArgs e)
        {

            if (ViewStident.SelectedRows.Count > 0)
            {
                int number = ViewStident.SelectedRows[0].Index;

                if (number >= 0 && number < student_.Count)
                {
                    Student X = student_[number];

                    FirstNameTextBox.Text = X.FirstName;
                    LastNameTextBox.Text = X.LastName;
                    MiddleNameTextBox.Text = X.MiddleName;
                    DateOfBirthTextBox.Text = X.DateOfBirth.ToString("dd.MM.yyyy");
                    ClassIdTextBox.Text = X.ClassId.ToString();
                    ParentPhoneNumberTextBox.Text = X.ParentPhoneNumber;
                    AcademicPerformanceTextBox.Text = X.AcademicPerformance;
                }
                else
                {
                    MessageBox.Show("Ошибка: Индекс строки вне диапазона.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку в таблице.");
            }


        }

        private void LoadStudentData()
        {
            SQLConnector SQL = new SQLConnector();
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM students";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                   int StudentId = Reader.GetInt32(0);
                   string FirstName = Reader.GetString(1);
                    string LastName = Reader.GetString(2);
                    string MiddleName = Reader.GetString(3);
                    DateTime DateOfBirth = Reader.GetDateTime(4);
                    string ClassId = Reader.GetString(5);
                    string ParentPhoneNumber = Reader.GetString(6);
                    string AcademicPerformance = Reader.GetString(7);

                    Student st = new Student(StudentId, FirstName, LastName, MiddleName, DateOfBirth, ClassId, ParentPhoneNumber, AcademicPerformance);
                    student_.Add(st);

                }
                con.Close();
                ViewStident.DataSource = null; 
                ViewStident.DataSource = student_;

                ViewStident.SelectionChanged += ViewStident_SelectionChanged;
                if (ViewStident.Rows.Count > 0)
                {
                    ViewStident.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void AddBlock_Click(object sender, EventArgs e)
        {
            string inputPassword = PasswordInputTextBox.Text.Trim();
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
                        FirstNameTextBox.Enabled = true;
                        LastNameTextBox.Enabled = true;
                        MiddleNameTextBox.Enabled = true;
                        DateOfBirthTextBox.Enabled = true;
                        ClassIdTextBox.Enabled = true;
                        ParentPhoneNumberTextBox.Enabled = true;
                        AcademicPerformanceTextBox.Enabled = true;
                        Update.Enabled = true;
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

        private void Exit_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ViewStident.SelectedRows.Count > 0)
            {
                int selectedIndex = ViewStident.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < student_.Count)
                {
                    int studentId = student_[selectedIndex].StudentId;
                    string firstName = FirstNameTextBox.Text.Trim();
                    string lastName = LastNameTextBox.Text.Trim();
                    string middleName = MiddleNameTextBox.Text.Trim();
                    string dateOfBirth = DateOfBirthTextBox.Text.Trim();
                    string classId = ClassIdTextBox.Text.Trim();
                    string parentPhoneNumber = ParentPhoneNumberTextBox.Text.Trim();
                    string academicPerformance = AcademicPerformanceTextBox.Text.Trim();

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    {
                        MessageBox.Show("Поля Имя и Фамилия обязательны для заполнения.");
                        return;
                    }

                    SQLConnector SQL = new SQLConnector();
                    string cs = SQL.GetConnect();

                    try
                    {
                        using (var con = new MySqlConnection(cs))
                        {
                            con.Open();

                            string stm = $"UPDATE students SET " +
                                         $"FirstName = '{firstName}', " +
                                         $"LastName = '{lastName}', " +
                                         $"MiddleName = '{middleName}', " +
                                         $"DateOfBirth = '{dateOfBirth}', " +
                                         $"ClassId = '{classId}', " +
                                         $"ParentPhoneNumber = '{parentPhoneNumber}', " +
                                         $"AcademicPerformance = '{academicPerformance}' " +
                                         $"WHERE StudentId = {studentId}";

                            var cmd = new MySqlCommand(stm, con);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены!");

                                Student updatedStudent = new Student(
                                    studentId,
                                    firstName,
                                    lastName,
                                    middleName,
                                    DateTime.Parse(dateOfBirth),
                                    classId,
                                    parentPhoneNumber,
                                    academicPerformance
                                );

                                student_[selectedIndex] = updatedStudent;

                                ViewStident.DataSource = null;
                                ViewStident.DataSource = student_;
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
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для обновления.");
            }
        }
    }
}
