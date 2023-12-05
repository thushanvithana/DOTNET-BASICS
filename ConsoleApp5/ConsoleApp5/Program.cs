using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //looping 

            for (int i = 0; i <= 5556; i++) { 
            
            Console.WriteLine(i);
            
            }

            //console writeline 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello world2");


            //variables 

            string name = "John";
            int number = 0;
            double doubleNumber = 10;
            char letter = 'A';
            bool booleanValue = false;


            Console.WriteLine("String values is : "  +  name);
            Console.WriteLine("Number value is :" + number);
            Console.WriteLine("Double value is : " + doubleNumber);
            Console.WriteLine("the letter value is :" + letter);
            Console.WriteLine("the boolean value is : " +  booleanValue);


            //casting 
            //implicit casting
            int myInt = 9;
            double myDouble = myInt;


            //explicit casting 
            double myDoubleNumber = 9.8;

            int convertToInt = (int)myDoubleNumber;




            //user inputs 
            Console.WriteLine("Enter user name :");
            string userName = Console.ReadLine();


            Console.WriteLine("Enter your age ");
            int age = Int16.Parse(Console.ReadLine());


            Console.WriteLine("User name is :" + age);


            //conditional statments 

            double marks;

            Console.WriteLine("Enter marks:");
            marks = Double.Parse(Console.ReadLine());


            if (marks >= 75) {
                Console.WriteLine("Your grade is A");
            }
            else if (marks >= 65) {
                Console.WriteLine("Your grade is B");
            }
            else if (marks >= 35) {
                Console.WriteLine("Your grade is C");
            }
            else {
                Console.WriteLine("You are failed");
            }


            //Switch statments 
            Console.WriteLine("Enter day");

            int day = Int16.Parse(Console.ReadLine());

            switch (day) {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wendsday");
                    break;
                default:
                    Console.WriteLine("Invalid date");
                    break;
            }



            //while statement 
            int count = 0;
            while (count <= 10) {

                Console.WriteLine("value is :"+ count);
                count++;
            
            }





            









            
           








        }
    }
}