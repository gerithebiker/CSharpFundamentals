using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class TextEx
    {
        public void TrimDemo()
        {
            var fullName = "   Greg A Szóközös   ";
            Console.WriteLine("Trim> '{0}'", fullName.Trim());
        }
        public void Consecutive()
        {
            Console.Write("Enter hyphen separated numbers: ");
            var myText = Console.ReadLine();
            if (!String.IsNullOrEmpty(myText))
            {
                var myArray = myText.Split('-');
                var direction = 0;
                var previousNumber = 0;
                var isFirst = true;
                foreach (var item in myArray)
                {
                    if (isFirst)
                    {
                        direction = Convert.ToInt32(myArray[1]) - Convert.ToInt32(myArray[0]);
                        previousNumber = Convert.ToInt32(item);
                        isFirst = false;
                    }
                    else
                    {
                        if(Convert.ToInt32(item) - previousNumber == direction)
                        {
                            previousNumber = Convert.ToInt32(item);
                        }
                        else
                        {
                            Console.WriteLine("Not Consecutive...");
                            return;
                        }
                    }
                } 
            } else { 
                Console.WriteLine("No input...");
                return;
            }
            Console.WriteLine("Consecutive!");
            return;
            //var myNumbers = new List<Int32>();

        }
        public void TwentyFour()
        {
            Console.Write("Provide me a valid time between 00:00 and 23:59! ");
            var myInput = Console.ReadLine();
            if (!String.IsNullOrEmpty(myInput))
            {
                var myArray = myInput.Split(':');
                if (Convert.ToInt16(myArray[0]) >= 0 && Convert.ToInt16(myArray[0])<24) 
                {
                    if(Convert.ToInt16(myArray[1]) >= 0 && Convert.ToInt16(myArray[1]) < 60)
                    {
                        Console.WriteLine("Correct time format.");
                        return;
                    }else { 
                        Console.WriteLine("Incorect!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("No input...");
                return;
            }
        }
        public void PascalCase()
        {
            Console.Write("Give me a few words space separated: ");
            var myInput = Console.ReadLine().Trim(); // to avoid "out of range" error, if you type in extra space accidentaly...
            
            if (!String.IsNullOrEmpty(myInput))
            {
                var myResult = "";
                foreach (var word in myInput.Split(' ')) {
                    var myWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                    myResult += myWord;
                }
                Console.WriteLine("Pascal: " +  myResult);
            }
            else
            {
                Console.WriteLine("You did not give me anything... So disappointed...");
                return;
            }
        }
    }
}
