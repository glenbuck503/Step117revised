using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_117
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Number resultNumber = new Number();
            resultNumber.Divide(100);
            Number resultNumber1 = new Number();
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            resultNumber1.Divide(userInput);
            Console.ReadLine();

            Additions addNumberTotal = new Additions();
            addNumberTotal.Addition(50,100, out int x);
            Console.ReadLine();


            Number stringNumber = new Number();
            int result = stringNumber.Divide("200");
            Console.WriteLine(result);
            Console.ReadLine();

           

            


        }
        

       







    }
}
