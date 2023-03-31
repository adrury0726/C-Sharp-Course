using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    internal class Program
    {
        //Uses unique values just like HashTables, such as an ID
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Antorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8)
            };

            //Int is the key, string is the value
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
            { 1, "one" },
            { 2, "two"},
            { 3, "three"}
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

 
            for(int i = 0; i < employeesDirectory.Count; i++)
            {
                //Using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i); //ElementAt will return according to sequence of titles. IE, position 1, 2, 3, etc. in the dictionary

                //print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);

                //Storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;

                //Printing the properties of the empolyee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }


            string key = "CEO";
            if(employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee was found with the key {0}", key);
            }

            Employee result = null;
            //Using TryGetValue() it returns to return true if the operation was successful, but return false otherwise
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }




        }

        class Employee
        {
            //Few properties like Role Name, Age, and Rate
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }
            //Yearly Salary = rate/h * number of days * number of weeks * number of months
            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;
                }
            }
            //Simple Constructor
            public Employee(string role, string name, int age, float rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }

        }
    }
 }