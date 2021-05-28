using System;

namespace Loneliest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            loneliest_num();
        }

        public static void loneliest_num()
        {
            for(int i = 1; i < 1000; i++)
            {
                int x = i + 1;
                if( i == 1)
                {
                    Console.WriteLine(i + " is the loneliest number that you'll ever do, " + x + " can be as bad as " + i + " it's the loneiest number since the number " + i + ".\n");
                }
                else Console.WriteLine(x + " can be as bad as " + i + " it's the loneiest number since the number " + i + ".\n");
            }
        }
    }
}
