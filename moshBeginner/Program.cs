//1- Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
//using System;

//class Example
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

//class Example
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

using System;
using System.Linq;

class Example
{

    // Main Method 
    public static void Main()
    {
        string number;

        Console.WriteLine("Please give me two numbers, a width and height, comma seperated ");

        // Converted string to array
        number = Console.ReadLine();
        //char[] numberArray = number.ToCharArray();

        int[] array = number.Split(',').Select(str => int.Parse(str)).ToArray();


        //Console.WriteLine(array[1]);

        if (array[0] == array[1])
        {
            Console.WriteLine("The width: {0} and the height {1} are the same", array[0], array[1]);

        }
        else if (array[0] > array[1])
        {
            Console.WriteLine("The image is landscape");

        }
        else Console.WriteLine("The image is portrait");



    }
}


//4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

//using System;

//namespace moshBeginner
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}
