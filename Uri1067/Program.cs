using System;

namespace Uri1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            for(int c=0; c<=x;c++)
            {
                if(c%2!=0)
                {
                    Console.WriteLine(c);
                }
                        
            }
        }
    }
}
