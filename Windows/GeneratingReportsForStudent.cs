using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using School.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using WordText = DocumentFormat.OpenXml.Wordprocessing.Text;
using WordBody = DocumentFormat.OpenXml.Wordprocessing.Body;

namespace School.Windows
{
   
    public partial class GeneratingReportsForStudent : Form
    {   SQLConnector SQL = new SQLConnector();
        List<Student> student_ = new List<Student>();
        public GeneratingReportsForStudent()
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

        private void GeneratingReportsForStudent_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void DismissEmployee_Click(object sender, EventArgs e)
        {
            if (StudentView.SelectedRows.Count > 0)
            {
                var selectedRow = StudentView.SelectedRows[0];
                int studentId = (int)selectedRow.Cells[0].Value;
                string dismissalReason = WhatYourСause.Text; 
                DateTime dismissalDate = DateTime.Parse(DataOtchislen.Text);

                string cs = SQL.GetConnect();
                try
                {
                    using (var con = new MySqlConnection(cs))
                    {
                        con.Open();
                        string updateStmt = "UPDATE students SET DismissalReason = @DismissalReason, DismissalDate = @DismissalDate WHERE StudentId = @StudentId";
                        using (var cmd = new MySqlCommand(updateStmt, con))
                        {
                            cmd.Parameters.AddWithValue("@DismissalReason", dismissalReason);
                            cmd.Parameters.AddWithValue("@DismissalDate", dismissalDate);
                            cmd.Parameters.AddWithValue("@StudentId", studentId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Информация успешно обновлена в базе данных.");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось обновить данные.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
                }

                GenerateDismissalReport(studentId, dismissalReason, dismissalDate);
            }
            else
            {
                MessageBox.Show("Выберите ученика для отчисления.");
            }
        }
        private void GenerateDismissalReport(int studentId, string dismissalReason, DateTime dismissalDate)
        {
            Student student = student_.Find(s => s.StudentId == studentId);
            if (student == null)
            {
                MessageBox.Show("Не удалось найти ученика.");
                return;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = Path.Combine(desktopPath, $"Отчет_об_отчислении_{student.LastName}_{DateTime.Now:yyyyMMddHHmmss}.docx");

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    WordBody body = new WordBody();

                    body.Append(new Paragraph(new Run(new WordText("Отчет об отчислении ученика")))
                    {
                        ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center })
                    });

                    body.Append(new Paragraph(new Run(new WordText($"Дата создания: {DateTime.Now:dd.MM.yyyy}"))));
                    body.Append(new Paragraph(new Run(new WordText($"ФИО: {student.FirstName} {student.LastName} {student.MiddleName}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Дата отчисления: {dismissalDate:dd.MM.yyyy}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Причина отчисления: {dismissalReason}"))));
                    body.Append(new Paragraph(new Run(new WordText($"Класс: {student.ClassId}"))));

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
