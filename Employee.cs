using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    public class Employee
    {
        //Skapar properties för Id,Name,Surname,Gender och Salary då bara gender är public och kan nås av program.cs tillfälligt.
        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        public string Gender { get; set; }
        private double Salary { get; set; }
        //---------------------------------------------------------------------------------

        //Här skrivs constructorn om pågrund av propertiesen.
        public Employee(int id, string name, string surname, string gender, double salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Gender = gender;
            Salary = salary;
        }
        //---------------------------------------------------------------------------------

        //En metod för att skriva ut alla objekten.
        public void Printing()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Salary: {Salary}");
        }
        //---------------------------------------------------------------------------------
    }
}
