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
    public partial class AddStudent : Form
    {
        SQLConnector SQL = new SQLConnector();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string cs = SQL.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();

                if (DateTime.TryParseExact(DateOfBirth.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateOfBirth))
                {
                    string formattedDate = dateOfBirth.ToString("yyyy-MM-dd");

                    var stm = String.Format(
                        "INSERT INTO students (FirstName, LastName, MiddleName, DateOfBirth, ClassId, ParentPhoneNumber, AcademicPerformance) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                        FirstName.Text, LastName.Text, MiddleName.Text, formattedDate, ClassId.Text, ParentPhoneNumber.Text, AcademicPerformance.Text);

                    using (var cmd = new MySqlCommand(stm, con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Новая запись успешно добавлена!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: Некорректный формат даты рождения. Введите дату в формате ДД.ММ.ГГГГ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
           this.Close();
            var IntermediateForSEC = new IntermediateForSEC();
            IntermediateForSEC.ShowDialog();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            MiddleName.Text = "";
            DateOfBirth.Text = "";
            ClassId.Text = "";
            ParentPhoneNumber.Text = "";
            AcademicPerformance.Text = "";
        }
    }
}
