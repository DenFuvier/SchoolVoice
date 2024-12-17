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
        /// <summary>
        /// идентификатор сотрудника
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Паспортные данные
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Дата найма
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Дата увольнения
        /// </summary>
        public DateTime? DismissalDate { get; set; }

        /// <summary>
        /// Позиция
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary { get; set; }

        public Employee(int employeeId, string firstName, string lastName, string middleName, string passportNumber, string phoneNumber, string email, DateTime dateOfBirth, DateTime hireDate, DateTime? dismissalDate, string position, int salary)
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
        }
    }
}
