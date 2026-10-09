namespace Homework3
{
    class Program
    {
        static void Main()
        {
            // Array with 3 rows and 4 columns
            int[,] Array =
            {
                {3,24,1,30 },
                {7,2,-5,23 },
                {4,0,11,13 }
            };

            // The user enters the limit
            Console.Write("Enter number: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Above(Array, limit);

        }


        static void Above(int[,] Array, int limit)
        {
            int c1 = 0;
            //counts the numbers exceeding the limit, for the correct initialization of the array size
            foreach (int n in Array)
            { if (n>limit) { c1++; } }

            int count = 0;
            //a new one-dimensional array for numbers exceeding the limit
            int[] arr = new int[c1];

            // two-deminsional loop which counts numbers exceeding the limit
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (limit < Array[i, j])
                    {
                        arr[count] = Array[i, j];
                        count++;
                    }

                }
            }
            //print
            Console.WriteLine($"Greater than {limit}:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine(".");
        }



    }




}