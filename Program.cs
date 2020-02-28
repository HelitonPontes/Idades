using System;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,idade = 0;
            double j = 0.00;
            double total;
            for ( i = 1; i>0; i++)
            {
                i = int.Parse(Console.ReadLine());
                
                
                if (i > 0)
                {
                    j = j + 1;
                    idade += i;
                }
               
            }
            total = idade / j;

            Console.WriteLine(j);

            Console.WriteLine(idade);

            Console.WriteLine(total.ToString("#0.00"));
        }
    }
}
