//PROBLEM SET 1
//1- Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        int number;

//        Console.WriteLine("Enter your an number: ");


//        // Converted string to int 
//        number = Convert.ToInt32(Console.ReadLine());


//        if (number > 0 && number < 11)
//        {
//            Console.WriteLine("Valid");
//        }
//        else
//        {
//            Console.WriteLine("Invalid");
//        }
//    }
//}



//2- Write a program which takes two numbers from the console and displays the maximum of the two.

//using System;
//using System.Linq;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        string number;

//        Console.WriteLine("Please give me two numbers, comma seperated ");

//        // Converted string to array
//        number = Console.ReadLine();
//        //char[] numberArray = number.ToCharArray();

//        int[] array = number.Split(',').Select(str => int.Parse(str)).ToArray();


//        //Console.WriteLine(array[1]);

//        if (array[0] > array[1])
//        {
//            Console.WriteLine("The first number: " + array[0] + " is bigger!");
//        }
//        else if (array[0] < array[1])
//        {
//            Console.WriteLine("The second number: " + array[1] + " is bigger!");

//        }

//        else {
//            Console.WriteLine("The numbers: " + array[1] + array[0] + "are the same!");
//        }




//    }
//}


//3- Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

//using System;
//using System.Linq;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        string number;

//        Console.WriteLine("Please give me two numbers, a width and height, comma seperated ");

//        // Converted string to array
//        number = Console.ReadLine();
//        //char[] numberArray = number.ToCharArray();

//        int[] array = number.Split(',').Select(str => int.Parse(str)).ToArray();


//        //Console.WriteLine(array[1]);

//        if (array[0] == array[1])
//        {
//            Console.WriteLine("The width: {0} and the height {1} are the same", array[0], array[1]);

//        }
//        else if (array[0] > array[1])
//        {
//            Console.WriteLine("The image is landscape");

//        }
//        else Console.WriteLine("The image is portrait");



//    }
//}


////4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
//Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit,
//program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km/hr above the speed limit,
//1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {

//        Console.WriteLine("What is the speed limit?");
//        int speedLimit = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("What is the current speed?");
//        int currentSpeed = Convert.ToInt32(Console.ReadLine());



//        if (currentSpeed < speedLimit)
//        {
//            Console.WriteLine("Speed OK");

//        }
//        else if (currentSpeed > speedLimit)
//        {
//            int demeritPoints = (currentSpeed - speedLimit) / 5;

//            if (demeritPoints > 12)
//            {
//                Console.WriteLine("License Suspended!");
//            } else if (demeritPoints > 0 && demeritPoints < 12)
//            {
//                Console.WriteLine("A penalty of {0} demerit points", demeritPoints);

//            }
//            else Console.WriteLine("Warning, within 5kph of speed limit");

//        }
//    }
//}



//PROBLEM SET 2
//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        int count = 0;
//    for (int i = 1; i <= 100; i++)
//        {
//            if (i % 3 == 0)
//            {
//                count++;
//            }
//        }
//        Console.WriteLine(count);
//    }
//}


//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

using System;

class Program
{
    static void Main()
    {

        int sum = 0;
        string number = "0";

        while (number != "ok")
        { 
            Console.WriteLine("Please enter a number, or type 'ok' to exit: ");

            number = Console.ReadLine();

            if (number == "ok")
            {
                break;
            }
            else
            {
                int numberInt = Convert.ToInt32(number);

                sum += numberInt;
            }
        }
        Console.WriteLine("The total is: " + sum);
    }
}



//3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.



//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)



//5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.