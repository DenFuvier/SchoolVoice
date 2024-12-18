using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace School
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string DismissalReason { get; set; }

        public Employee(int employeeId, string firstName, string lastName, string middleName, string passportNumber,
                        string phoneNumber, string email, DateTime dateOfBirth, DateTime hireDate, DateTime? dismissalDate,
                        string position, int salary, string dismissalReason = null)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PassportNumber = passportNumber;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfBirth = dateOfBirth;
            HireDate = hireDate;
            DismissalDate = dismissalDate;
            Position = position;
            Salary = salary;
            DismissalReason = dismissalReason;
        }
    }
}
