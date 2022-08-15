using System;

namespace Oop
{
    public abstract class Employee
    {
        private int employeeId;
        private string name;
        private double salary;
        private double deduction;

        //Constructor
        public Employee() { }
        public Employee(int id, string n)
        {
            employeeId = id;
            name = n;
        }

        //Getter-Setter
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                employeeId = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }

        public double Deduction
        {
            get { return deduction; }
            set
            {
                deduction = value;
            }
        }

        //Display Method
        public void Display()
        {
            Console.WriteLine("Id =" + employeeId);
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Salary =" + salary);
        }
        //Abstract Method
        public abstract double calculateSalary(double days);
        public abstract double calculateDeduction();
        public abstract double calculateNetPay();

    }
}
