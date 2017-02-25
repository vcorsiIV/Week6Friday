using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BonusWeek6Friday
{
    class Bonus
    {
        string strInt;
        int userInt;

        public void userInput()
        {
            Write("Enter in a number to display a multiplication table:\t");
            strInt = Console.ReadLine();
        }

        public void mulTable()
        {
            int[] intArr = new int[11];
            userInt = int.Parse(strInt);
            for (int i = 0; i < 11; i++)
            {
                int prod = userInt* i;
                WriteLine(userInt + " * " + i +" = " + prod);
                
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] retedTable = new int[11];
                Bonus mt = new Bonus();
                mt.userInput();
                mt.mulTable();
            }
        }
    }
}
