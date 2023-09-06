using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Exercises
    {
        public void Facebook()
        {
            var myNames = new List<string>();

            Console.Write("What is the first name? ");
            var myInput = Console.ReadLine();

            while (myInput.Length > 0)
            {
                myNames.Add(myInput);
                Console.Write("Give me another name: ");
                myInput = Console.ReadLine();
            }
            switch (myNames.Count)
            {
                case 0:
                    Console.WriteLine("No one likes me...");
                    break;
                case 1:
                    Console.WriteLine($"{myNames[0]} likes my post!");
                    break;
                case 2:
                    Console.WriteLine($"{myNames[0]} and {myNames[1]} likes my post!");
                    break;
                default:
                    Console.WriteLine($"{myNames[0]}, {myNames[1]} and {myNames.Count - 2} likes my post!");
                    //Console.WriteLine($"likes my post!");
                    //for (int i = 2; i < ; i++)
                    //{
                    //    Console.Write(myNames[i]);
                    //}
                    break;
            }
        }
        public void ReverseName()
        {
            Console.Write("Please give me your name, I will reverse it: ");
            var myInput = Console.ReadLine();
            var reverseArray = new char[myInput.Length];
            for(var i = reverseArray.Length; i > 0; i--)
            {
                reverseArray[reverseArray.Length - i] = myInput[i-1];
            }
            var reverseString = new string(reverseArray);
            Console.WriteLine($"This is your name in reverse: {reverseString}");
        }
        public void FiveNumbers()
        {
            var myArray = new int[5];
            Console.WriteLine("I am expecting 5 separated numbers, but none of them should be the same!");
            Console.Write("Give me the first number: ");
            myArray[0] = Convert.ToInt32(Console.ReadLine());
            var i = 1;
            while(i<5)
            {
                Console.Write("Give me the next: ");
                var myInput = Convert.ToInt32(Console.ReadLine());
                if(Array.IndexOf(myArray, myInput) == -1)
                {
                    myArray[i] = myInput;
                    i++;
                }
                else
                {
                    Console.WriteLine("You gave me this number already!");
                }
            }
            Array.Sort(myArray);
            Console.WriteLine("Here are all the numbers you gave:");
            foreach(var number  in myArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
