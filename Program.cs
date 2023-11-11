using System.Reflection;
using System.Xml.Linq;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här skapas objekten för de olika employeesen.
            Employee employee1 = new Employee(105, "Albert", "Einstein", "Male", 25000);
            Employee employee2 = new Employee(104, "Aldor", "Eriksson", "Male", 35000);
            Employee employee3 = new Employee(103, "Roger", "Johansson", "Male", 55000);
            Employee employee4 = new Employee(102, "Hanna", "Söderqvist", "Female", 15000);
            Employee employee5 = new Employee(101, "Stina", "Östqvist", "Female", 20000);
            //---------------------------------------------------------------------------------
            //Skapar en Stack och pushar in objekten i stacken.
            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);
            //---------------------------------------------------------------------------------
            //Skriver ut alla objekten ifrån stacken.
            foreach (Employee employee in employees)
            {
                employee.Printing();
                Console.WriteLine($"Items left in stack = {employees.Count}");
                Console.WriteLine(" ");
            }
            //---------------------------------------------------------------------------------

            Console.WriteLine("------------------------");
            Console.WriteLine("Retrive Using Pop Method");

            //En variabel som definerar hur många employees det finns i stacken.
            int employeeCount = employees.Count();
            //---------------------------------------------------------------------------------
            //En forloop som tar bort och returnerar värdet och skriver ut värdet samt hur många objekt som finns kvar i stacken tills det tar slut i stacken.
            for (int i = 0; i < employeeCount; i++)
            {
                Employee employee = employees.Pop();
                employee.Printing();
                Console.WriteLine($"Items left in stack = {employees.Count}");
                Console.WriteLine(" ");
            }
            //---------------------------------------------------------------------------------
            //Här pushas alla objekt upp igen eftersom det inte finns några kvar i stacken efter förra forloopen.
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);
            //---------------------------------------------------------------------------------

            Console.WriteLine("------------------------");
            Console.WriteLine("Retrive Using Peek Method");

            //Samma som pop forloopen bara det att den inte tar bort objekten från stacken
            for (int i = 0; i < 2; i++)
            {
                Employee employee = employees.Peek();
                employee.Printing();
                Console.WriteLine($"Items left in stack = { employees.Count}");
                Console.WriteLine(" ");
            }
            //---------------------------------------------------------------------------------

            Console.WriteLine("------------------------");

            //Här kollar koden om objektet employee3 existerar eller inte.
            if (employees.Contains(employee3)) { Console.WriteLine(" "); Console.WriteLine("employee3 exists"); Console.WriteLine(" "); } else { Console.WriteLine("employee3 doesnt exist"); Console.WriteLine(" "); }
            //---------------------------------------------------------------------------------

            //Skapar en Lista och Adderar in objekten i listan.
            List<Employee> workers = new List<Employee>();
            workers.Add(employee1);
            workers.Add(employee2);
            workers.Add(employee3);
            workers.Add(employee4);
            workers.Add(employee5);
            //---------------------------------------------------------------------------------

            //Här kollar koden om objektet employee2 existerar eller inte fast med contains metoden.
            if (workers.Contains(employee2)) { Console.WriteLine("Employee2 object exists in the list"); Console.WriteLine(" "); } else { Console.WriteLine("Employee2 object does not exist in the list"); Console.WriteLine(" "); }
            //---------------------------------------------------------------------------------

            //En variabel skapas för att lagra det returnerade värdet om vilken den första är som har "Male" i gender.
            Employee worker = workers.Find(employeeX => employeeX.Gender == "Male");
            //---------------------------------------------------------------------------------

            //Här skapas en variabel för att lagra det returnerade värdet om vilka det är som har "Male" i gender.
            List<Employee> results = workers.FindAll(employeeX => employeeX.Gender == "Male");
            //---------------------------------------------------------------------------------

            //Om stacken inte är null så skriver metoden ut det första objektet som har "Male" som gender.
            if (worker is not null) { worker.Printing(); Console.WriteLine(" "); }
            //---------------------------------------------------------------------------------
            //Om stacken inte är null så skriver metoden ut alla objekt som har "Male" som gender.
            if (results is not null) { foreach (Employee employee in results) { employee.Printing(); Console.WriteLine(" "); } }
            //---------------------------------------------------------------------------------
        }
    }
    
}