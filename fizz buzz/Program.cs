using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =0; i <100; i++) 
            {
                if (i % 15== 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5== 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3== 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 2!= 0) 
                {
                    Console.WriteLine("Unven" + i . ToString());
                }
                else 
                {
                      Console.WriteLine(i);
                }
                  i=i+1;
            }
            
        }
    }
}
