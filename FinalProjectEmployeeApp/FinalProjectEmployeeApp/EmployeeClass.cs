using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEmployeeApp
{
    class EmployeeClass
    {
        private string firstName;
        private string lastName;
        private string empType;
        private double salary;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EmpType
        {
            get
            {
                return empType;
            }

            set
            {
                empType = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
        public EmployeeClass()
        {
            //no arg contructor
        }

        public EmployeeClass(string firstName, string lastName, string empType, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmpType = empType;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return lastName + "," + firstName + "\t" + empType + "\t" + salary; 
        }
        public string ToFileString()
        {
            return lastName + "," + firstName + "," + empType + "," + salary;
        }
    }
}
