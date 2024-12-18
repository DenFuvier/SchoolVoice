using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using School.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class GeneretingReportsFormForEmploersInvate : Form
    {
        SQLConnector SQL = new SQLConnector();
        List<Employee> employees_ = new List<Employee>();
        public GeneretingReportsFormForEmploersInvate()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var TheChoiceIsYours = new TheChoiceIsYours();
            TheChoiceIsYours.Show();
        }

        private void InvateWordPrint_Click(object sender, EventArgs e)
        {
            if (EmployeeVIew.SelectedRows.Count > 0)
            {
                var selectedRow = EmployeeVIew.SelectedRows[0];
                int employeeId = (int)selectedRow.Cells[0].Value;
                var employee = employees_.Find(emp => emp.EmployeeId == employeeId);

                if (employee != null)
                {
                    GenerateHiringReport(employee);
                }
                else
                {
                    MessageBox.Show("Не удалось найти сотрудника с таким ID.");
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для генерации отчета.");
            }
        }

        private void GenerateHiringReport(Employee employee)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"{employee.FirstName}_{employee.LastName}_Hiring_Report.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());
                    Body body = mainPart.Document.Body;
                    body.Append(new Paragraph(new Run(new Text("Приказ о принятии на работу"))));
                    body.Append(new Paragraph(new Run(new Text($"Сотрудник: {employee.FirstName} {employee.LastName} {employee.MiddleName}"))));
                    body.Append(new Paragraph(new Run(new Text($"Дата рождения: {employee.DateOfBirth.ToShortDateString()}"))));
                    body.Append(new Paragraph(new Run(new Text($"Должность: {employee.Position}"))));
                    body.Append(new Paragraph(new Run(new Text($"Дата принятия на работу: {employee.HireDate.ToShortDateString()}"))));
                    body.Append(new Paragraph(new Run(new Text($"Зарплата: {employee.Salary}"))));
                    wordDocument.Close();
                    MessageBox.Show($"Отчет о принятии сотрудника сохранен на рабочем столе: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}");
            }
        }

        private void GeneretingFormForEmploersInvate_Load(object sender, EventArgs e)
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
    }
}
