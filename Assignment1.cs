using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment1
    {
        public int MultiplicationOfTwoNumbers()
        {

            Console.WriteLine("Enter First No.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No.");
            int num2 = Convert.ToInt32(Console.ReadLine());

             int product = num1 * num2;

            Console.WriteLine("The answer is " + product);
            return product;

            

        }

        public string AddingPY()
        {
            Console.WriteLine("Add your Keyword");
            string keyword = Console.ReadLine();
            if (keyword.StartsWith("PY") || keyword.StartsWith("py"))
            {
                return keyword;
            }
            else {
                string newWord = "Py" + keyword;
                Console.WriteLine("The new keyword is " + newWord);
                return newWord;
            }
            
        }

        public string ChangingFirstAndLastPositions()
        {
            Console.WriteLine("Enter your Character ");
            string keyword = Console.ReadLine();
            string newWord = 
        }

    }
}
