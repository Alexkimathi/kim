using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] names = {67, 56, 89};
            
                string[] name = {"alex", "kim", "joy"};
                int myvalue = names[1];
                int mysecondvalue = names[0];
                int result = myvalue + mysecondvalue;
            
            Console.WriteLine(myvalue);
            Console.WriteLine(mysecondvalue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}