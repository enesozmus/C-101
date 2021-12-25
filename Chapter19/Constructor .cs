using System;

namespace Chapter19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***** Çalışan-1 *****");
            Employee employee_1 = new Employee(001, "Enes", "Ozmus", "İnsan Kaynakları");
            employee_1.EmployeeManager();
            Console.WriteLine("\n***** Çalışan-2 *****");
            Employee employee_2 = new Employee(002, "Ahmet", "Ozmus", "Finans");
            employee_2.EmployeeManager();
            Console.WriteLine("\n***** Çalışan-3 *****");
            Employee employee_3 = new Employee("Ali", "Ozmus");
            employee_3.EmployeeManager();
        }
    }

    class Employee
    {
        public Employee(){}     // default
        
        public int Id;
        public string FirstName;
        public string LastName;
        public string Department;

        public Employee(int id, string firstName, string lastName, string department)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
        }
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void EmployeeManager()
        {
            Console.WriteLine("Personel ID: {0}", Id);
            Console.WriteLine("Personel adı: {0}", FirstName);
            Console.WriteLine("Personel soyadı: {0}", LastName);
            Console.WriteLine("Personel departmanı: {0}", Department);
        }
    }
}
