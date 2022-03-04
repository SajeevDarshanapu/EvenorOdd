using System;
namespace EvenorOdd
{
    public class EvenOdd
    {
        public static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine($"Given number {num} is even",num);
            }
            else
            {
                Console.WriteLine($"Given number {num} is odd",num );
            }
        }
    }
}
