using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secnum;
            string operation;
            double answer;
            string Reply;

            Console.WriteLine("hello welcome to my calculator");
            Console.Write("\n");

            while (true)
            {
                Console.WriteLine("enter the first number");
                firstnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second number");
                secnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now enter the Operation");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        answer = firstnum + secnum;
                        Console.WriteLine("the aswer is ={0}", answer);
                        Console.ReadLine();
                        break;

                    case "-":
                        answer = firstnum - secnum;
                        Console.WriteLine("the aswer is ={0}", answer);
                        Console.ReadLine();
                        break;

                    case "*":
                        answer = firstnum * secnum;
                        Console.WriteLine("the aswer is ={0}", answer);
                        Console.ReadLine();
                        break;

                    case "/":
                        answer = firstnum / secnum;
                        Console.WriteLine("the aswer is ={0}", answer);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("invalid operation");
                        Console.ReadLine();
                        break;


                }
                Console.Write("do you want to continue? Y/N :");
                Reply = Console.ReadLine();
                if (Reply == "y")
                {
                    continue;

                    Console.Write("\n");

                }
                else if (Reply == "n")
                {
                    Console.WriteLine("exit");
                    break;
                }
            }
        }
    }
}
