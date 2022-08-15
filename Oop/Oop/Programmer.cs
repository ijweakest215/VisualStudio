using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public class Programmer : Employee
    {
        private string language;
        //Constrcutor
        public Programmer() { }
        public Programmer(int id, string n, string l) : base(id, n)
        {
            language = l;
        }
        //Getter-Setter
        public string Language
        {
            get { return language; }
            set
            {
                language = value;
            }
        }
        public void display()
        {
            Console.WriteLine("Id: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Programming Language: " + Language);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Deduction: " + calculateDeduction());
            Console.WriteLine("Net Pay: " + calculateNetPay());
        }
        //Override Abstract
        public override double calculateSalary(double days)
        {
            Salary = 950 * days;
            return Salary;
            throw new NotImplementedException();
        }
        public override double calculateDeduction()
        {
            Deduction = Salary * .19;
            return Deduction;
            throw new NotImplementedException();
        }
        public override double calculateNetPay()
        {
            return Salary - Deduction;
            throw new NotImplementedException();
        }
    }
}
