namespace annoing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testTal = { 1, 2, 3, };

            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av 1, 2, 3 är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av 1, 2, 3 är: "); // TODO
        }

        public static int Summan(int[] listOfNumbers)
        {
            int sum = 0;    
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                sum = sum + listOfNumbers[i];   
            }
            return sum;
        }

        public static int biggest(int[] listOfNumbers)
        {
            int biggest = 0;

            for (int i = 0; i < listOfNumbers.Length; i++)
            {

            }
            return biggest;
        }
    }

}