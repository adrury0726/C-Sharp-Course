namespace UsingArraysasParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            int[] happiness = { 2, 3, 4, 5, 6};
            SunIsShining(happiness);

            foreach (int y in happiness)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();

        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void SunIsShining(int[] x)
        {
            for(int i = 0; i < x.Length;i++)
                x[i] += 2; //Adding 2 onto the Happiness list above
            
        }
    }
}