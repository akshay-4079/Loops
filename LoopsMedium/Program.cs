using System;

namespace LoopsMedium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            nestedFor();
            whilebreak();
            dowhile();
        }

        private static void dowhile()
        {

            int i = 0;

            while (i < 2)
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = 1;

                i++;

                while (j < 2)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                }
            }
        }

        private static void whilebreak()
        {
            int i = 0;

            while (true)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 10)
                    break;
            }
        }

        private static void nestedFor()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }

        }
    }
}
