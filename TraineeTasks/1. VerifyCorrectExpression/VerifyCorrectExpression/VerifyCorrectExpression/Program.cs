using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyCorrectExpression
{
    class Program
    {
        private static readonly char[] OpenBrackets = { '(', '[' };
        private static readonly char[] CloseBrackets = { ')', ']' };

        public static string Check(string input)
        {
            Stack<int> brackets = new Stack<int>();
            foreach (char singleChar in input)
            {
                int index;

                if ((index = Array.IndexOf(OpenBrackets, singleChar)) != -1)
                {
                    brackets.Push(index);  
                }
                
                else if ((index = Array.IndexOf(CloseBrackets, singleChar)) != -1)
                {
                    if (brackets.Count == 0 || brackets.Pop() != index)
                        return "No";
                }
            }
            return "Yes";
        }
        static void Main(string[] args)
        {
            string inputExpression = "(1 + 2) * (3 -[4 + 5])";
            Console.WriteLine("InputExpression {0} is correct? {1}!", inputExpression, Check(inputExpression));
            Console.ReadKey();
        }
    }
}
