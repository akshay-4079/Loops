using System;

namespace LoopsHArd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            dowhile();
            nesteddo();
        }

        private static void nesteddo()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;

                } while (j < 2);

            } while (i < 2);
        }

        private static void dowhile()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

            } while (i < 10);

        }
    }
}
