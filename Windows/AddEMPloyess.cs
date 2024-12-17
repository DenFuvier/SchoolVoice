using MySql.Data.MySqlClient;
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
    public partial class AddEMPloyess : Form
    {
        SQLConnector SQL = new SQLConnector();
        public AddEMPloyess()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        { 
            this.Hide();
            this.Close();
            var IntermediateFormDIR = new IntermediateFormDIR();
            IntermediateFormDIR.ShowDialog();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            PassportNumberTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            EmailTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            HireDateTextBox.Text = "";
            PositionTextBox.Text = "";
            SalaryTextBox.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();

                if (DateTime.TryParseExact(DateOfBirthTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateOfBirth) &&
                    DateTime.TryParseExact(HireDateTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime hireDate))
                {
                    string formattedDateOfBirth = dateOfBirth.ToString("yyyy-MM-dd");
                    string formattedHireDate = hireDate.ToString("yyyy-MM-dd");

                    var stm = String.Format(
                        "INSERT INTO employees (FirstName, LastName, MiddleName, PassportNumber, PhoneNumber, Email, DateOfBirth, HireDate, Position, Salary) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                        FirstNameTextBox.Text, LastNameTextBox.Text, MiddleNameTextBox.Text, PassportNumberTextBox.Text,
                        PhoneNumberTextBox.Text, EmailTextBox.Text, formattedDateOfBirth, formattedHireDate,
                        PositionTextBox.Text, SalaryTextBox.Text);

                    using (var cmd = new MySqlCommand(stm, con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Новая запись успешно добавлена!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: Некорректный формат даты. Введите дату в формате ДД.ММ.ГГГГ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
            }
        }
    }
}
