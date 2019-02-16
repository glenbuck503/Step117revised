using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_117
{
    public class Number
    {
        public void Divide(int firstNumber)
        {
            int firstNumberDivide = firstNumber / 2;
            Console.WriteLine(firstNumberDivide);
            return;
            
        }

        public void Divide(int firstNumber, int secondNumber)
        {

            int firstNumberAdd = firstNumber + 2;
            Console.WriteLine(firstNumberAdd);
            return;
                
        }

        public int Divide(string StringNumber)
        {
            int EditedStringNumber = Convert.ToInt32(StringNumber);
            return EditedStringNumber - 100;

        }











    }
}
