namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 27;
            int minTripleNumber = 100;
            int maxTripleNumber = 999;
            int counterMultipleNumbers = 0;

            Random random = new Random();
            int numberN = random.Next(minNumber, maxNumber);

            for (int currentNumber = 0; currentNumber < maxTripleNumber; currentNumber += numberN)
            {
                if (currentNumber >= minTripleNumber)
                {
                    counterMultipleNumbers++;
                }
            }

            Console.WriteLine("Количество трехзначных натуральных чисел кратных " + numberN + " равно " + counterMultipleNumbers);
            Console.ReadLine();
        }
    }
}