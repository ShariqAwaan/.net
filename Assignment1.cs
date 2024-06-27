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
            else
            {
                string newWord = "Py" + keyword;
                Console.WriteLine("The new keyword is " + newWord);
                return newWord;
            }

        }

        public string ChangingFirstAndLastPositions()
        {
            Console.WriteLine("Enter your Character ");
            string keyword = Console.ReadLine();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 2)
            {
                Console.WriteLine("The input is too short or empty.");
                return keyword;
            }

            string newWord = keyword[keyword.Length - 1]
                + keyword.Substring(1, keyword.Length - 2)
                + keyword[0];
            Console.WriteLine("The new keyword is " + newWord);
            return newWord;
        }

        public int SquareOfNumber()
        {
            Console.WriteLine("Enter your no. ");
            int number = Convert.ToInt32(Console.ReadLine());
            int Square = Convert.ToInt32(Math.Pow(number, 2));
            Console.WriteLine(Square);
            return Square;
        }

        public string ChangingSpecificKeyword()
        {
            Console.WriteLine("Enter your Keyword");
            string keyword = Console.ReadLine();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 2)
            {
                Console.WriteLine("The input is too short or empty.");
                return keyword;
            }

            Console.WriteLine("Enter character to be removed");
            string givenWord = Console.ReadLine();

            if (string.IsNullOrEmpty(givenWord) || givenWord.Length > 1)
            {
                Console.WriteLine("The input is too long or empty.");
                return keyword;
            }

            //string indexOfGivenWord = keyword[givenWord];
            string newKeyword = keyword.Replace(givenWord, "");

            Console.WriteLine("The new keyword is " + newKeyword);
            return newKeyword;


        }

        public int MultipleOf3or7()
        {
            Console.WriteLine("Enter your number :");
            int givenNumber = Convert.ToInt32(Console.ReadLine());

            if (givenNumber % 3 == 0 && givenNumber % 7 == 0)
            {
                Console.WriteLine("The given no. is multiple of both 3 and 7");

            }
            else if (givenNumber % 7 == 0)
            {
                Console.WriteLine("The given no. is multiple of 7");

            }
            else if (givenNumber % 3 == 0)
            {
                Console.WriteLine("The given no. is multiple of 3");
            }
            else
            {
                Console.WriteLine("Given no. is niether multiple of 3 nor 7");

            }
            return givenNumber;

        }

        public int FindingLargestValue()
        {
            Console.WriteLine("Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber && firstNumber == thirdNumber)
            {
                Console.WriteLine("All values are equal ");
                return firstNumber;
            }
            else if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The First no. is the Largest ");
                return firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The Second no. is the Largest ");
                return secondNumber;
            }
            else
            {
                Console.WriteLine("The Third no. is the Largest ");
                return thirdNumber;
            }
        }

        //ArmStrongNumbers

        public int ArmStrongNumbers()
        {
            Console.WriteLine("Enter the number in range of 100 to 1000 ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Please enter a value bw 100 and 1000");
                return number;
            }

            string stringValue = number.ToString();

            int char1 = Convert.ToInt32(stringValue[0].ToString());
            int char2 = Convert.ToInt32(stringValue[1].ToString());
            int char3 = Convert.ToInt32(stringValue[2].ToString());

            int cubeOfChar1 = Convert.ToInt32(Math.Pow(char1, 3));
            int cubeOfChar2 = Convert.ToInt32(Math.Pow(char2, 3));
            int cubeOfChar3 = Convert.ToInt32(Math.Pow(char3, 3));

            int cubeOfAllNo = cubeOfChar1 + cubeOfChar2 + cubeOfChar3;


            if (number == cubeOfAllNo)
            {
                Console.WriteLine("The given number is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("The given number is not an Armstrong number.");
            }

            return number;

        }

        //Sum of Multiples of 3and5 under 1000 using loop

        public int SumOfMultiples()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }

            }
            Console.WriteLine(result);
            return result;
        }


        //FizzBuzz

        public int SumOfMultiples2()
        {
            for (int i = 0; i < 100; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            return 0;

        }


        //Odd or even
        public int OddEven()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "is even");
                }
                else
                {
                    Console.WriteLine(i + "is odd");
                }
            }
            return 0;
        }

        //Sort an array of string
        public string ArrayOfStrings()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            for (int i = 0; i < cars.Length; i++ )
            {
                Console.WriteLine(cars[i]);
            }
            return "0";
        }


        //SumOfAllElementsOfTwoArrays

        public int SumOfTwoArrays()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array2 = { 100, 200, 300, 400, 500 };

            int sumOfFirstArray = array1.Sum();
            int sumOfSecondArray = array2.Sum();

            int totalSum = sumOfFirstArray + sumOfSecondArray;
            Console.WriteLine(totalSum);
            return totalSum;
        }

        //Outputting Array in reverse order using for loop

        public void ArrayInReverseOrder()
        {
            string[] array = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Original Array:");
            foreach (var item in array)
            {
                Console.Write(item+",");
            }
             Array.Reverse(array);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Reversed Array:");

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }
            

        }


    }
}
