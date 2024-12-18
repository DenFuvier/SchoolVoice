using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Classes
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ClassId { get; set; }
        public string ParentPhoneNumber { get; set; }
        public string AcademicPerformance { get; set; }
        public string DismissalReason { get; set; }
        public DateTime? DismissalDate { get; set; }
        public Student(int studentId, string firstName, string lastName, string middleName, DateTime dateOfBirth,
                       string classId, string parentPhoneNumber, string academicPerformance,
                       string dismissalReason = null, DateTime? dismissalDate = null)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            ClassId = classId;
            ParentPhoneNumber = parentPhoneNumber;
            AcademicPerformance = academicPerformance;
            DismissalReason = dismissalReason;
            DismissalDate = dismissalDate;
        }
    }
}
