using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Taw(int x, int y)
        {
            return x - y;
        }
        public bool Valid(int checknumber)
        {
            if (checknumber > 0 && checknumber < 10)
            {
                Console.WriteLine("True value!");
                return true;
            } else
            {
                Console.WriteLine("Not a valid value!");
                return false;
            }
        }
        public string passGen(int pwdLength)
        {
            var random = new Random();
            var buffer = new char[pwdLength];
            
            for (var i=0; i<pwdLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
            return password;
        }

        public int Max(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine("First is bigger: " + first);
                return first;
            }
            else
            {
                Console.WriteLine("Second is bigger: " + second);
                return second;
            }
        }
        public string Landscape(int first, int second)
        {
            if (first == second)
            {
                Console.WriteLine("It is square...");
                return "Square";
            }
            else if (first > second)
            {
                Console.WriteLine("Portrait!");
                return "Portrait";
            }
            else
            {
                Console.WriteLine("Landscape......");
                return "Landscape";
            }
        }

        public string SpeedLimit(int first, int second)
        {
            double myPercent = (double)second / first;
            Console.WriteLine("The value is: " + myPercent);
            switch (myPercent)
            {
                case <= 1:
                    Console.WriteLine("Nice driver!!");
                    return "All good";
                case <= 1.05:
                    Console.WriteLine("One point");
                    return "One point";
                case <= 1.1:
                    Console.WriteLine("Two point");
                    return "Two point";
                case <= 1.15:
                    Console.WriteLine("Three point");
                    return "Three point";
                default:
                    Console.WriteLine("License suspended!!!");
                    return "License suspended!!!";
            }
        }
        // recursive function 
        public int factorial(int num)
        {
            // termination condition
            if (num == 0)
                return 1;
            else
                // recursive call
                return num * factorial(num - 1);
        }

        public (int elso, int masodik, int harmadik) RecurSpeed(int n, int v)
        {
            return (n, v, 1);
        }
        
        public void NewSpeed(int speedLimit, int carSpeed)
        {
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;

                Console.WriteLine("Demerit points: " + demeritPoints);

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
        public int ByThree(int maxNumber)
        {
            var myCounter = 0;
            for(var i=1; i<=maxNumber; i++)
            {
                if(i % 3 == 0)
                {
                    myCounter++;
                }
            }
            Console.WriteLine("There are " + myCounter + " number between 1 and " + maxNumber + " that is divisible by 3.");
            return myCounter;
        }
    }
}




