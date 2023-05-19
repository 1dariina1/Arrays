using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] mas = new int[3, 3];
            
            int maxSum = 0;
            int maxsumRow = 0;
            int rows= mas.GetLength(0); 
            int cols= mas.GetLength(1);

            Console.WriteLine($"Enter {3 * 3} elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += mas[i, j]; 
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxsumRow = i;

                }
            }
            Console.WriteLine($"Number row with the maximum sum of elements = {maxsumRow}");
            Console.ReadLine(); 
          
        }
       
    }
}
