using System;
using System.Collections;

namespace HashTables
{
    internal class Program
    {
        //Always have a unique value for specic entries in a hash table

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "John", 76);
            Student stud3 = new Student(3, "Jeff", 43);
            Student stud4 = new Student(4, "Dylan", 55);

            studentsTable.Add(stud1.ID, stud1);
            studentsTable.Add(stud2.ID, stud2);
            studentsTable.Add(stud3.ID, stud3);
            studentsTable.Add(stud4.ID, stud4);

            //Retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.ID]; //Using ID value for this hash.

            //Retrieve all values from a HashTable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}", temp.ID);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.ID);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

         //   Console.WriteLine("Student ID: {0}, Name: {1}, GPA {2}", storedStudent1.ID, storedStudent1.Name, storedStudent1.GPA);

        }

        class Student
        {
            //Property called ID
            public int ID { get; set; }

            //Property called name
            public string Name { get; set; }

            //Property called GPA
            public float GPA { get; set; }

            //Simple Constuctor
            public Student(int id, string name, float GPA)
            {
                this.ID = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}