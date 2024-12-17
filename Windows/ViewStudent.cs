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
        SQLConnector SQL = new SQLConnector();
        List<Student> student_ = new List<Student>();
        private string currentUserRole;
        public ViewStudent()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Delete.Enabled = false;
            ViewStident.ReadOnly = true;
            FirstNameTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;
            MiddleNameTextBox.Enabled = false;
            DateOfBirthTextBox.Enabled = false;
            ClassIdTextBox.Enabled = false;
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

        }

        private void LoadStudentData()
        {
            student_.Clear();

            string cs = SQL.GetConnect();
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = "SELECT * FROM students";
                    using (var cmd = new MySqlCommand(stm, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int StudentId = reader.GetInt32(0);
                            string FirstName = reader.GetString(1);
                            string LastName = reader.GetString(2);
                            string MiddleName = reader.GetString(3);
                            DateTime DateOfBirth = reader.GetDateTime(4);
                            string ClassId = reader.GetString(5);
                            string ParentPhoneNumber = reader.GetString(6);
                            string AcademicPerformance = reader.GetString(7);

                            Student st = new Student(
                                StudentId,
                                FirstName,
                                LastName,
                                MiddleName,
                                DateOfBirth,
                                ClassId,
                                ParentPhoneNumber,
                                AcademicPerformance
                            );
                            student_.Add(st);
                        }
                    }
                }

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
                        Delete.Enabled = true;
                        PasswordInputTextBox.Text = "";
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
            this.Hide();
            this.Close();
            var IntermediateForSEC = new IntermediateForSEC();
            IntermediateForSEC.Show();
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

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ViewStident.SelectedRows.Count > 0)
            {
                int rowIndex = ViewStident.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < student_.Count)
                {
                    Student selectedStudent = student_[rowIndex];

                    DialogResult dialogResult = MessageBox.Show(
                        "Вы уверены, что хотите удалить этого студента?",
                        "Подтвердите удаление",
                        MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string cs = SQL.GetConnect();
                        try
                        {
                            using (var con = new MySqlConnection(cs))
                            {
                                con.Open();

                                string stm = $"DELETE FROM students WHERE StudentId = {selectedStudent.StudentId}";

                                using (var cmd = new MySqlCommand(stm, con))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Студент успешно удален.");
                            LoadStudentData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: неверный индекс строки.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }
        }
    }
}