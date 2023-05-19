using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace масиви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;
            int[] mas = new int[10];
            Console.WriteLine("Enter ten numbers:");
            for (int i = 0; i < 10; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
                for (int i=0; i<10; i++)
            {  
                if (mas[i]>0)
                {
                    sum += mas[i];
                }

                if (mas[i] % 2 == 0)
                {
                    n++;
                }
            }
            Console.WriteLine("Sum = {0}",sum);
            Console.WriteLine("Even numbers = {0}", n);
            Console.ReadLine();
        }
    }
}
