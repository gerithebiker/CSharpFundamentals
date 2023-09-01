using System.Security.Cryptography;
using System;
using Conditionals;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public enum ShippingMethod // :byte can be used instead of integer
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    };


    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Title;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

        class Program
    {
        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine("In the function: " + number);
        }
        public static void Season(int season) {
            switch (season)
            {
                case 3:
                    Console.WriteLine("It is Fall...");
                    break;
                case 1:
                    Console.WriteLine("It is Spring now...");
                    break;
                case 2:
                    Console.WriteLine("Argh, summer time...");
                    break;
                case 4:
                    Console.WriteLine("Finally, it is winter!!!");
                    break;
                default:
                    Console.WriteLine("Something is wrong...");
                    break;
            }
        }
 

        public static void DayState(int hour)
        {
            if(hour > 0 && hour < 12) {
                Console.WriteLine("It;s morning.");
            } else if(hour > 12 && hour < 18) {
                Console.WriteLine("It's afternoon.");
            }
            else { Console.WriteLine("It's evening."); }
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        static void Main(string[] args)
        {
            Exercises exercise = new Exercises();
            exercise.Facebook();
            
            var numbersList = new List<int>() { 1, 2, 3, 2, 5, 2, 6 };
            numbersList.Add(13);
            numbersList.Sort();
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbersList.IndexOf(2));

            int[] numbers3 = new int[4] { 1, 2, 3, 4 };
            Array.Sort(numbers3);

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            Console.Write("Gimme a list of numbers divided by comma: ");
            var inputString = Console.ReadLine();

            Calculator calculator = new Calculator();
            // as inputString "could be" a null value, we have to verify and then call the function
            if (inputString != null)
            {
                calculator.MaxOfList(inputString);
            }
            calculator.ByThree(300);
            calculator.OtherMax();
            calculator.FourChance();
            var result = calculator.Add(1, 4);
            Console.WriteLine(result);
            result = calculator.Taw(6, 2);
            Console.WriteLine(result);
            var numbers = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine(numbers[3]);
            var name = string.Format("Ezt akarom most kiirni: {0} {1}, {1}", john.FirstName, john.LastName);
            Console.WriteLine(name);
            string list = string.Join(", ", numbers);
            Console.WriteLine(list);
            string path = @"C:\projects\folder";
            Console.WriteLine(path);


            var method = ShippingMethod.RegisteredAirMail;
            Console.WriteLine("My method is: " + method + ", value is: " + (int)method);

            var methodName = "Express";
            var myShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("MyShippingMethod: " + myShippingMethod);

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("Values a: {0}, b: {1}", a, b));

            var numbers2 = numbers;
            Console.WriteLine(string.Format("First numbers 0: {0}, numbers2: {1}", numbers[0], numbers2[0]));
            numbers2[0] = 33;
            Console.WriteLine(string.Format("Numbers 0: {0}, numbers2: {1}", numbers[0], numbers2[0]));

            int myNumber = 1;
            Increment(myNumber);
            Console.WriteLine("After function: " + myNumber);

            var person = new Person() {Age = 20};
            Console.WriteLine("Person new age: " + person.Age);
            
            MakeOld(person);
            Console.WriteLine("Person new age: " + person.Age);

            DayState(10);
            DayState(12);
            DayState(13);
            bool isGoldCust = false;
            float price = (isGoldCust) ? 19.95f : 29.95f;
            Console.WriteLine("$"+price);

            var myStuff = Conditionals.Season.Fall;
            Console.WriteLine(myStuff);
            Season((int)myStuff);
            Season((int)myStuff + 6);

            int myX = 0;
            int myY = 0;


            Console.Write("First thing: ");
            var myZ = Console.ReadLine();
            if(!int.TryParse(myZ, out myX));
            Console.WriteLine("Added 5... " + (myX + 5));

            Console.Write("First number: ");
            myZ = Console.ReadLine();
            Console.Write("Second number: ");
            var myW = Console.ReadLine();
            if (!int.TryParse(myZ, out myX));
            if (!int.TryParse(myW, out myY)) ;

            calculator.Max(myX, myY);

            calculator.Landscape(myX, myY);
            calculator.Landscape(myY, myX);
            calculator.Landscape(3, 3);

            calculator.SpeedLimit(myX, myY);

            Console.Write("Gimme a number dude: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            var fact = calculator.factorial(num);

            Console.WriteLine("Factorial of {0} is {1}", num, fact);

            Console.Write("Enter the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the car's speed: ");
            int carSpeed = int.Parse(Console.ReadLine());

            calculator.NewSpeed(speedLimit, carSpeed);
            calculator.passGen(speedLimit);
        }
    }
}


