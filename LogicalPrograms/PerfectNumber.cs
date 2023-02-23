using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void perfectNo()
        {
            int number, sum = 0;
            Console.WriteLine("Enter the number to check Perfect Number or not");//6
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("Entered number " + number + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine("Entered number " + number + " is not a Perfect Number");
            }
        }
    }
}
