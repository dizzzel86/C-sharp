using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._6
{
    struct Worker
    {
        #region Конструкторы
        public string firstName;
        public string lastName;
        public string position;
        public uint salary;
        public string department;


        public Worker(string FirstName, string LastName, string Position, uint Salary, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.position = Position;
            this.salary = Salary;
            this.department = Department;
        }

        #endregion


        #region Методы

        public string Print()
        {
            return $"{this.firstName,15} {this.lastName,15} {this.position,15}{this.salary,15}{this.department,15}";
        }


        #endregion


        #region Свойства

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public string Position { get { return this.position; } set { this.position = value;} }

        public uint Salary { get {  return this.salary; } set { this.salary = value;} }

        public string Department { get { return this.department; } set { this.department = value;} }

        //public double HourRate





        #endregion



        #region Поля






        #endregion
    }
}
