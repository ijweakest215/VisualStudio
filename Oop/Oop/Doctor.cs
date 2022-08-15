using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public class Doctor : Employee
    {
        private string specialization;

        //constructor
        public Doctor() { }
        public Doctor(int id, string n, string spec) : base(id, n)
        {
            specialization = spec;
        }

        //Getter-Setter
        public string Specialization
        {
            get { return specialization; }
            set
            {
                specialization = value;
            }
        }
        public void display()
        {
            Console.WriteLine("Id: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Specialization: " + Specialization);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Deduction: " + calculateDeduction());
            Console.WriteLine("Net Pay: " + calculateNetPay());
        }

        //Override Abstract Methods
        public override double calculateSalary(double days)
        {
            if (specialization == "Pediatrician")
            {
                Salary = 1050 * days;
            }
            else if (specialization == "Ob-Gynecologist")
            {
                Salary = 2650 * days;
            }
            else if (specialization == "Neurologist")
            {
                Salary = 6575 * days;
            }
            else
            {
                Salary = 0 * days;
            }
            return Salary;
        }
        public override double calculateDeduction()
        {
            if (Salary <= 10000)
            {
                Deduction = Salary * .11;
            }
            else if (Salary > 10000 && Salary <= 20000)
            {
                Deduction = Salary * .215;
            }
            else if (Salary > 20000 && Salary <= 30000)
            {
                Deduction = Salary * .34;
            }
            else if (Salary > 30000)
            {
                Deduction = Salary * .58;
            }
            else
            { throw new NotImplementedException(); }
            return Deduction;
        }
        public override double calculateNetPay()
        {
            return Salary - Deduction;
            throw new NotImplementedException();
        }

    }
}
