using System;
using System.Collections;


/*Write a program that will iterate through each element of the students array and insert them into a hashtable. 
  If a student with the same ID already exists in the hashtable, skip it and display the following error:
  "Sorry, a student with the same ID already exists."
    Hint: Use the method ContainsKey() to check whether or not a student with the same ID already exists.
*/

namespace HashTablesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student[] students = new Student[6];
            students[0] = new Student(1, "Jeff", 88);
            students[1] = new Student(2, "Dylan", 80);
            students[2] = new Student(3, "Daniel", 71);
            students[3] = new Student(4, "Jessica", 50);
            students[4] = new Student(5, "Chris", 57);
            students[5] = new Student(5, "Chris", 57);


            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.ID))  //Checks if the ID num already exists or not
                {
                    table.Add(s.ID, s);
                    Console.WriteLine("Student with ID {0} was added!", s.ID);
                }
                else
                {
                    s.ID = s.ID + 1;
                    Console.WriteLine("Sorry, a student with that same ID already exists. Your new ID is {0}", s.ID);
                }

            }
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