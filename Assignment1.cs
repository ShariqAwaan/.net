using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment1
    {

        //MultiplicationOfTwoNumbers

        public void MultiplicationOfTwoNumbers()
        {

            Console.WriteLine("Enter First No.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * num2;

            Console.WriteLine("The answer is " + product);



        }

        //AddingPY

        public void AddingPY()
        {
            Console.WriteLine("Add your Keyword");
            string keyword = Console.ReadLine();
            if (keyword.StartsWith("PY") || keyword.StartsWith("py"))
            {
                 Console.WriteLine(keyword);
            }
            else
            {
                string newWord = "Py" + keyword;
                Console.WriteLine("The new keyword is " + newWord);
            }

        }

        //ChangingFirstAndLastPositions

        public void ChangingFirstAndLastPositions()
        {
            Console.WriteLine("Enter your Character ");
            string keyword = Console.ReadLine();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 2)
            {
                Console.WriteLine("The input is too short or empty.");
            }

            string newWord = keyword[keyword.Length - 1]
                + keyword.Substring(1, keyword.Length - 2)
                + keyword[0];
            Console.WriteLine("The new keyword is " + newWord);
        }

        //Adding first 3 chars. on front and back

        public void AddingChar()
        {
            Console.WriteLine("Enter your word ");
            string keyword = Console.ReadLine();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 2)
            {
                Console.WriteLine("The input is too short or empty.");
            }

            string firstThree = keyword.Substring( 0 , 3);
            //Console.WriteLine(firstThree);

            string newWord = firstThree + keyword + firstThree;
            Console.WriteLine( newWord );

        }

        //SquareOfNumber
        public void SquareOfNumber()
        {
            Console.WriteLine("Enter your no. ");
            int number = Convert.ToInt32(Console.ReadLine());
            int Square = Convert.ToInt32(Math.Pow(number, 2));
            Console.WriteLine(Square);
        }

        //ChangingSpecificKeyword

        public void ChangingSpecificKeyword()
        {
            Console.WriteLine("Enter your Keyword");
            string keyword = Console.ReadLine();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 2)
            {
                Console.WriteLine("The input is too short or empty.");
            }

            Console.WriteLine("Enter character to be removed");
            string givenWord = Console.ReadLine();

            if (string.IsNullOrEmpty(givenWord) || givenWord.Length > 1)
            {
                Console.WriteLine("The input is too long or empty.");
            }

            //string indexOfGivenWord = keyword[givenWord];
            string newKeyword = keyword.Replace(givenWord, "");

            Console.WriteLine("The new keyword is " + newKeyword);


        }


        //MultipleOf3or7
        public void MultipleOf3or7()
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

        }

        //FindingLargestValue

        public void FindingLargestValue()
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
            }
            else if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The First no. is the Largest ");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The Second no. is the Largest ");
            }
            else
            {
                Console.WriteLine("The Third no. is the Largest ");
            }
        }

        //ArmStrongNumbers

        public void ArmStrongNumbers()
        {
            Console.WriteLine("Enter the number in range of 100 to 1000 ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Please enter a value bw 100 and 1000");
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


        }

        //Sum of Multiples of 3and5 under 1000 using loop

        public void SumOfMultiples()
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
        }


        //FizzBuzz

        public void SumOfMultiples2()
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

        }


        //Odd or even
        public void OddEven()
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
        }

        //Sort an array of string
        public void ArrayOfStrings()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            for (int i = 0; i < cars.Length; i++ )
            {
                Console.WriteLine(cars[i]);
            }
        }


        //SumOfAllElementsOfTwoArrays

        public void SumOfTwoArrays()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array2 = { 100, 200, 300, 400, 500 };

            int sumOfFirstArray = array1.Sum();
            int sumOfSecondArray = array2.Sum();

            int totalSum = sumOfFirstArray + sumOfSecondArray;
            Console.WriteLine(totalSum);
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

        //Finding Factorial

        public void FindingFactorial()
        {
            Console.WriteLine("Enter your number");
            int result = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number ; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }




        //Using While Loop

        //NoFrom1to10

        public void NoBw1and10()
        {
            int i = 1;
            while (i <= 10)
            { 
                Console.WriteLine(i);
                i++;
            }

        }

        //using do while
        public void Bw1and10()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
        }

        //printing even no. in a given array
        public void EvenNoInArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 82, 9, 10, 11, 12, 13, 14, 50, 55, 56 };
            int i = 0;
            while ( i < array.Length){
                if (array[i] % 2 == 0) 
                {
                    Console.WriteLine(array[i]);
                }
                i++;
            }
        }


        //Array Methods of Select and Where
        //Make an array of numbers that are doubles of the first array

        public void DoublesOfFirstArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var doubledNumbers = array.Select(item => item*2);
            Console.WriteLine(string.Join(", ", doubledNumbers));
        }

        //Take an array of numbers and make them strings

        public void ConvertedToString()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var convertedToString = numbers.Select(item => item.ToString());
            Console.WriteLine(convertedToString.GetType());
            Console.WriteLine(string.Join(", ", convertedToString));
        }

        //Any array of numbers, return a new array that has only the numbers that are 5 or greater.

        public void GreaterThan5()
        {
            int[] numbers = { 1, 7, 3, 33, 9, 11 };
            var greaterThanFive = numbers.Where(item => item > 5).ToArray();
            Console.WriteLine(string.Join(", " , greaterThanFive));
        }



    }
}
