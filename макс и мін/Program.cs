using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace макс_и_мін
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int m = int.Parse(Console.ReadLine());

            int[,] mas = new int[n, m];
            Console.WriteLine($"Enter {n * m} elements");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int min = mas[0, 0];
            int max = mas[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > mas[i, j])
                    {
                        min = mas[i, j];
                    }
                    if (max < mas[i, j])
                    {
                        max = mas[i, j];
                    }
                }
            }
            sum = max + min;
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("The sum of the minimum and maximum = {0}", sum);
            Console.ReadLine();
        }
    }
}

       
          

   


