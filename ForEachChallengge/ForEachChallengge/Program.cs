namespace ForEachChallengge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Enter a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter: ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch(inputType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    //check for Boolean
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect the input type, something is wrong.");
                    break;
            }

            Console.WriteLine("You have entered a value: {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is valid: {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid: {0}", inputValueType);
            }
            Console.ReadKey();

            static bool IsAllAlphabetic(string value)
            {
                foreach(char c in value)
                {
                    if(!char.IsLetter(c))
                        return false;
                }
                return true;
            }

        }
    }
}