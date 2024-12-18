using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordText = DocumentFormat.OpenXml.Wordprocessing.Text;
using WordBody = DocumentFormat.OpenXml.Wordprocessing.Body;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class GeneratingReportsForEMP : Form
    {
        SQLConnector SQL = new SQLConnector();
        List<Employee> employees_ = new List<Employee>();
        public GeneratingReportsForEMP()
        {
            InitializeComponent();
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

        private void GenerateDismissalReport_Click(object sender, EventArgs e)
        {
            if (EmployeeVIew.SelectedRows.Count > 0)
            {
                int selectedIndex = EmployeeVIew.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < employees_.Count)
                {
                    Employee selectedEmployee = employees_[selectedIndex];

                    string dismissalReason = RichBoard.Text.Trim();
                    if (string.IsNullOrEmpty(dismissalReason))
                    {
                        MessageBox.Show("Укажите причину увольнения.");
                        return;
                    }

                    if (!DateTime.TryParseExact(DataYvolen.Text.Trim(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dismissalDate))
                    {
                        MessageBox.Show("Введите корректную дату увольнения в формате ДД.ММ.ГГГГ.");
                        return;
                    }

                    selectedEmployee.DismissalDate = dismissalDate;
                    selectedEmployee.DismissalReason = dismissalReason;

                    UpdateEmployeeDismissal(selectedEmployee.EmployeeId, dismissalDate, dismissalReason);

                    GenerateWordReport(selectedEmployee);
                }
                else
                {
                    MessageBox.Show("Выберите сотрудника для увольнения.");
                }
            }
            else
            {
                MessageBox.Show("Выберите строку в таблице.");
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            var IntermediateFormDIR = new IntermediateFormDIR();
            IntermediateFormDIR.Show();
        }

        private void GeneratingReports_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void UpdateEmployeeDismissal(int employeeId, DateTime dismissalDate, string dismissalReason)
        {
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();

                    string stm = $"UPDATE employees SET " +
                                 $"DismissalDate = '{dismissalDate:yyyy-MM-dd}', " +
                                 $"DismissalReason = '{dismissalReason}' " +
                                 $"WHERE EmployeeId = {employeeId}";

                    var cmd = new MySqlCommand(stm, con);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные об увольнении обновлены в базе.");
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
        private void GenerateWordReport(Employee employee)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = Path.Combine(desktopPath, $"Отчет_об_увольнении_{employee.LastName}_{DateTime.Now:yyyyMMddHHmmss}.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    WordBody body = new WordBody();

                    body.Append(new Paragraph(new Run(new WordText("Отчет об увольнении сотрудника")))
                    {
                        ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center })
                    });

                    body.Append(new Paragraph(new Run(new WordText($"Дата создания: {DateTime.Now:dd.MM.yyyy}"))));
                    body.Append(new Paragraph(new Run(new WordText($"ФИО: {employee.FirstName} {employee.LastName} {employee.MiddleName}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Должность: {employee.Position}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Дата увольнения: {employee.DismissalDate:dd.MM.yyyy}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Причина увольнения: {employee.DismissalReason}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Дата принятия на работу: {employee.HireDate:dd.MM.yyyy}"))));

                    mainPart.Document.Append(body);
                    mainPart.Document.Save();
                }

                MessageBox.Show($"Отчет успешно сохранен на рабочий стол: {fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета: {ex.Message}");
            }
        }
    }
}

