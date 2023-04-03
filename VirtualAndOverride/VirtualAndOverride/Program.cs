namespace VirtualAndOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Twyla", 5);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}