// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 21;
string name = "Aaron";
string job = "Developer";

Console.WriteLine("String Concatenation");
Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

Console.WriteLine("String Formatting");
Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}", name, age, job);

Console.WriteLine("String Formatting");
Console.WriteLine($"Hello \n my name is {name} , I am {age} years old. I'm a {job}");

Console.WriteLine(@"H:\C# Learning"); //Must use @ or it won't read the file path. Will try to read it as if it were \n







Console.ReadLine();