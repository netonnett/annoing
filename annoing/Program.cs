namespace annoing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testTal = { 1, 2, 3, };
            string[] names = { "Anna", "Bertil", "Cesar" };
            int[] swapTestData = { 8, 90, 6, 22,7,9 };
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            string[] rotateTestData = { "a", "b", "c", "d", "e" };

            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av 1, 2, 3 är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av 1, 2, 3 är: " + biggest(testTal)); // TODO

            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(names, "Bertil")); // true
            Console.WriteLine("Contains(David): " + Contains(names, "David")); // false

            // Swap
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: " + string.Join(",", swapTestData));
            Swap(2, 5, swapTestData); // ska fungera med olika index!
            Console.WriteLine("Efter: " + string.Join(",", swapTestData));

            // Concatenate
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));

            // Reverse
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();

            // Rotate
            Console.WriteLine("Demonstration av Rotate:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            string[] rotateTestDataResult = Rotate(rotateTestData, 2);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestDataResult));
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

            for (int i = 0; i < (listOfNumbers.Length -1); i++)
            {

                if (listOfNumbers[i] > listOfNumbers[i + 1])
                {
                    biggest = listOfNumbers[i];
                }
                else
                {
                    biggest = listOfNumbers[i + 1];
                }
            }
            return biggest;
        }

        public static bool Contains(string[] names, string name)
        {
            foreach(string s in names)
            {
                bool matchypatchy = s == name;
                if(matchypatchy)
                {
                    return true;
                }
               
            }

            return false; 
        }

        public static void Swap(int index1, int index2, int[] numbers)
        {
            int swapiesbefore = numbers[index2];

            numbers[index2] = numbers[index1];

            numbers[index1] = swapiesbefore;


        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] listtogether = new string[part1.Length + part2.Length];

            for(int i = 0; i < part1.Length; i++)
            {
                listtogether[i] = part1[i];
            }
            for (int i = 0; i < part2.Length; i++)
            {
                listtogether[part1.Length + i] = part2[i];
            }

            return listtogether;    
        }

        public static void Reverse(int[] numbers)
        {
            for(int i = 0; i < numbers.Length / 2; i++)
            {
                Swap(i, numbers.Length - 1 - i, numbers);
            }
        }

        public static string[] Rotate(string[] strings, int n)
        {
            string[] newfly = new string[strings.Length];
            for(int i = 0; i < strings.Length; i++)
            {
                newfly[(i + n ) % strings.Length] = strings[i];
                

            }

            return newfly;
        }


    }

}