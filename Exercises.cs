using System;
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
    }
}
