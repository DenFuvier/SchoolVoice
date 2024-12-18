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
    public partial class GeneretingReportsFormForStudentInvate : Form
    {   SQLConnector SQL = new SQLConnector();
        List<Student> student_ = new List<Student>();
        public GeneretingReportsFormForStudentInvate()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var TheChoiceIsYours = new TheChoiceIsYours();
            TheChoiceIsYours.Show();
        }
        private void GeneretingFormForStudentInvate_Load(object sender, EventArgs e)
        {
            LoadStudentData();
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
                    var stm = "SELECT StudentId, FirstName, LastName, MiddleName, DateOfBirth, ClassId, ParentPhoneNumber, AcademicPerformance, DismissalReason, DismissalDate FROM students";
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
                            string DismissalReason = reader.IsDBNull(8) ? null : reader.GetString(8);
                            DateTime? DismissalDate = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9);
                            Student st = new Student(
                                StudentId,
                                FirstName,
                                LastName,
                                MiddleName,
                                DateOfBirth,
                                ClassId,
                                ParentPhoneNumber,
                                AcademicPerformance,
                                DismissalReason,
                                DismissalDate
                            );
                            student_.Add(st);
                        }
                    }
                }

                StudentView.DataSource = null;
                StudentView.DataSource = student_;

                if (StudentView.Rows.Count > 0)
                {
                    StudentView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
            }
        }

        private void DismissStudent_Click(object sender, EventArgs e)
        {
            if (StudentView.SelectedRows.Count > 0)
            {
                var selectedRow = StudentView.SelectedRows[0];
                int studentId = (int)selectedRow.Cells[0].Value;

                GenerateAcceptanceReport(studentId);
            }
            else
            {
                MessageBox.Show("Выберите студента для создания отчета.");
            }
        }
        private void GenerateAcceptanceReport(int studentId)
        {
            var student = student_.Find(s => s.StudentId == studentId);

            if (student != null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, $"{student.FirstName}_{student.LastName}_Acceptance_Report.docx");

                try
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                        mainPart.Document = new Document(new Body());
                        Body body = mainPart.Document.Body;
                        body.Append(new Paragraph(new Run(new Text("Приказ о принятии ученика в школу"))));
                        body.Append(new Paragraph(new Run(new Text($"Имя: {student.FirstName} {student.LastName} {student.MiddleName}"))));
                        body.Append(new Paragraph(new Run(new Text($"Дата рождения: {student.DateOfBirth.ToShortDateString()}"))));
                        body.Append(new Paragraph(new Run(new Text($"Класс: {student.ClassId}"))));
                        body.Append(new Paragraph(new Run(new Text($"Дата принятия в школу: {DateTime.Now.ToShortDateString()}"))));
                        wordDocument.Close();
                        MessageBox.Show($"Отчет о принятии сохранен на рабочем столе: {filePath}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Студент не найден.");
            }
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var TheChoiceIsYours = new TheChoiceIsYours();
            TheChoiceIsYours.Show();
        }
    }
}
