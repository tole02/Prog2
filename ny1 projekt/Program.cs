using System;

namespace ny1_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int hej = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(hej);
                hej++;
            }

            if (hej==5){
                Console.WriteLine("cool");
            }
            Console.ReadLine();
        }
    }
}
