using System;

namespace LoopsEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            forLoop();
            breakloop();

        }

        private static void breakloop()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }
        }

        private static void forLoop()
        {
            int i = 0;

            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }
        }
    }
}
