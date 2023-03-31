// See https://aka.ms/new-console-template for more information

string myName;

Console.Write("Please enter your name and press enter: ");
myName = Console.ReadLine();

string myNameUpperCase = string.Format("Upper case : {0}", myName.ToUpper());
string myNameLowerCase = string.Format("Lower Case : {0}", myName.ToLower());
string myNameTrimmed = string.Format("Trimmed : {0}", myName.Trim()); //Will cut out that extra blank spot in the middle of the :
string myNameSubString = string.Format("SubString : {0}", myName.Substring(0, 5));


Console.WriteLine(myNameUpperCase);
Console.WriteLine(myNameLowerCase);
Console.WriteLine(myNameTrimmed);
Console.WriteLine(myNameSubString);

Console.ReadKey();

