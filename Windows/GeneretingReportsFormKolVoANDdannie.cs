using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using School.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class GeneretingReportsFormKolVoANDdannie : Form
    {
        SQLConnector SQL = new SQLConnector();
        List<Student> students_ = new List<Student>();
        List<Employee> employees_ = new List<Employee>();
        public GeneretingReportsFormKolVoANDdannie()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void GeneretingReportsFormKolVoStudent_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            employees_.Clear();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    string stm = "SELECT EmployeeId, FirstName, LastName, MiddleName, PassportNumber, PhoneNumber, Email, DateOfBirth, HireDate, DismissalDate, Position, Salary FROM employees";
                    using (var cmd = new MySqlCommand(stm, con))
                    using (var reader = cmd.ExecuteReader())
                    {
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

                            Employee employee = new Employee(
                                employeeId,
                                firstName,
                                lastName,
                                middleName,
                                passportNumber,
                                phoneNumber,
                                email,
                                dateOfBirth,
                                hireDate,
                                dismissalDate,
                                position,
                                salary
                            );
                            employees_.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void LoadStudentData()
        {
            students_.Clear();
            string cs = SQL.GetConnect();

            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    string stm = "SELECT StudentId, FirstName, LastName, MiddleName, DateOfBirth, ClassId, DismissalReason FROM students";
                    using (var cmd = new MySqlCommand(stm, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentId = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);
                            string middleName = reader.GetString(3);
                            DateTime dateOfBirth = reader.GetDateTime(4);
                            string classId = reader.GetString(5);
                            string dismissalReason = reader.IsDBNull(6) ? null : reader.GetString(6);

                            Student student = new Student(
                                studentId,
                                firstName,
                                lastName,
                                middleName,
                                dateOfBirth,
                                classId,
                                null,
                                null,
                                dismissalReason,
                                null
                            );
                            students_.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            GenerateStudentsReport();

        }
        private void GenerateStudentsReport()
        {
            int dismissedCount = 0;
            int activeCount = 0;

            foreach (var student in students_)
            {
                if (!string.IsNullOrEmpty(student.DismissalReason))
                    dismissedCount++;
                else
                    activeCount++;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "All_Students_Report.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());
                    Body body = mainPart.Document.Body;
                    body.Append(new Paragraph(new Run(new Text("Общий отчёт по студентам"))));
                    body.Append(new Paragraph(new Run(new Text($"Дата создания: {DateTime.Now.ToShortDateString()}"))));
                    body.Append(new Paragraph(new Run(new Text($"Всего студентов: {students_.Count}"))));
                    body.Append(new Paragraph(new Run(new Text($"Отчислено: {dismissedCount}"))));
                    body.Append(new Paragraph(new Run(new Text($"Активных: {activeCount}"))));
                    foreach (var student in students_)
                    {
                        string status = string.IsNullOrEmpty(student.DismissalReason) ? "Активен" : $"Отчислен ({student.DismissalReason})";
                        body.Append(new Paragraph(new Run(new Text($"- {student.FirstName} {student.LastName} ({student.ClassId}): {status}"))));
                    }
                    wordDocument.Close();
                    MessageBox.Show($"Отчёт сохранён на рабочем столе: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчёта: {ex.Message}");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var TheChoiceIsYours = new TheChoiceIsYours();
            TheChoiceIsYours.Show();
        }

        private void KolvoNPC_Click(object sender, EventArgs e)
        {
            GenerateEmployeesReport();
        }
        private void GenerateEmployeesReport()
        {
            int dismissedCount = 0;
            int activeCount = 0;

            foreach (var employee in employees_)
            {
                if (employee.DismissalDate.HasValue)
                    dismissedCount++;
                else
                    activeCount++;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "All_Employees_Report.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());
                    Body body = mainPart.Document.Body;
                    body.Append(new Paragraph(new Run(new Text("Общий отчёт по сотрудникам"))));
                    body.Append(new Paragraph(new Run(new Text($"Дата создания: {DateTime.Now.ToShortDateString()}"))));
                    body.Append(new Paragraph(new Run(new Text($"Всего сотрудников: {employees_.Count}"))));
                    body.Append(new Paragraph(new Run(new Text($"Уволено: {dismissedCount}"))));
                    body.Append(new Paragraph(new Run(new Text($"Активных: {activeCount}"))));
                    foreach (var employee in employees_)
                    {
                        string status = employee.DismissalDate.HasValue ? $"Уволен (Дата увольнения: {employee.DismissalDate.Value.ToShortDateString()})" : "Активен";
                        body.Append(new Paragraph(new Run(new Text($"- {employee.FirstName} {employee.LastName} ({employee.Position}): {status}"))));
                    }
                    wordDocument.Close();
                    MessageBox.Show($"Отчёт сохранён на рабочем столе: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчёта: {ex.Message}");
            }
        }

        private void PersonalLoad_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "EmployeeData.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());
                    Body body = mainPart.Document.Body;
                    body.Append(new Paragraph(new Run(new Text("Данные сотрудников")) { RunProperties = new RunProperties(new Bold()) }));
                    Table table = new Table();
                    TableRow headerRow = new TableRow();
                    headerRow.Append(
                        CreateTableCell("ID"),
                        CreateTableCell("Имя"),
                        CreateTableCell("Фамилия"),
                        CreateTableCell("Отчество"),
                        CreateTableCell("Паспорт"),
                        CreateTableCell("Телефон"),
                        CreateTableCell("Email"),
                        CreateTableCell("Дата рождения"),
                        CreateTableCell("Дата приёма"),
                        CreateTableCell("Дата увольнения"),
                        CreateTableCell("Должность"),
                        CreateTableCell("Зарплата")
                    );
                    table.Append(headerRow);
                    foreach (var employee in employees_)
                    {
                        TableRow dataRow = new TableRow();
                        dataRow.Append(
                            CreateTableCell(employee.EmployeeId.ToString()),
                            CreateTableCell(employee.FirstName),
                            CreateTableCell(employee.LastName),
                            CreateTableCell(employee.MiddleName),
                            CreateTableCell(employee.PassportNumber),
                            CreateTableCell(employee.PhoneNumber),
                            CreateTableCell(employee.Email),
                            CreateTableCell(employee.DateOfBirth.ToShortDateString()),
                            CreateTableCell(employee.HireDate.ToShortDateString()),
                            CreateTableCell(employee.DismissalDate?.ToShortDateString() ?? "Работает"),
                            CreateTableCell(employee.Position),
                            CreateTableCell(employee.Salary.ToString())
                        );
                        table.Append(dataRow);
                    }
                    body.Append(table);
                    wordDocument.Close();
                }
                MessageBox.Show($"Данные сотрудников успешно сохранены в файл: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        private TableCell CreateTableCell(string text)
        {
            return new TableCell(new Paragraph(new Run(new Text(text))));
        }
    }
}
