// See https://aka.ms/new-console-template for more information


Console.Write("Enter a string here: ");
string input = Console.ReadLine();

Console.Write("Enter a character to search: ");
char searchInput = Console.ReadLine()[0];

int searchIndex = input.IndexOf(searchInput);

Console.WriteLine("Index of character {0} in string is {1} ", searchInput, searchIndex);

Console.Write("Enter first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter last name: ");
string lastName = Console.ReadLine();

string fullName = string.Concat(firstName + " " + lastName);
Console.WriteLine("Your full name is {0}", fullName);

Console.ReadKey();