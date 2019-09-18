//PROBLEM SET 1
//1- Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        int number;

//        Console.WriteLine("Enter a number bewtween 1 - 10: ");


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

//using System;

//class Program
//{
//    static void Main()
//    {

//        int sum = 0;
//        string number = "0";

//        while (number != "ok")
//        { 
//            Console.WriteLine("Please enter a number, or type 'ok' to exit: ");

//            number = Console.ReadLine();

//            if (number == "ok")
//            {
//                break;
//            }
//            else
//            {
//                int numberInt = Convert.ToInt32(number);

//                sum += numberInt;
//            }
//        }
//        Console.WriteLine("The total is: " + sum);  
//    }
//}


//3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {

//        Console.WriteLine("Enter a number to factorialize: ");

//        // Converted string to int 
//        int numberToFactor = Convert.ToInt32(Console.ReadLine());

//        int factorial = Factorialize(numberToFactor);

//        Console.WriteLine("Factorial of {0} is {1}", numberToFactor, factorial);
//    }
//    public static int Factorialize(int number)
//    {
//        if (number == 0)
//        {
//            return 1;
//        }
//        return number * Factorialize(number - 1);
//    }
//}



//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
//   otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {

//        Random random = new Random();
//        int randomNumber = random.Next(1, 10);
//        Console.WriteLine("Random number: " + randomNumber);

//        int guess = 0;
//        while (guess < 4)
//        {
//            Console.WriteLine("Guess a number between 1-10. You will have four guesses: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            if (number == randomNumber)
//            {
//                Console.WriteLine("You guessed the right number!!!");
//                break;
//            }
//            else if (guess < 3)
//            {
//                Console.WriteLine("Guess Again");
//            }
//            else
//            {
//                Console.WriteLine("I'm sorry you are out of guesses, please play agian!");
//            }
//            guess++;
//        }
//    }
//}




//5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

//using System;
//using System.Linq;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        string number;

//        Console.WriteLine("Please give me a series of numbers, comma seperated ");

//        number = Console.ReadLine();

//        int[] array = number.Split(',').Select(str => int.Parse(str)).ToArray();

//        Console.WriteLine(array.Max());
//    }
//}

//using System;
//using System.Linq;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        string number;

//        Console.WriteLine("Please give me a series of numbers, comma seperated ");

//        number = Console.ReadLine();

//        int[] array = number.Split(',').Select(str => int.Parse(str)).ToArray();

//        int maxNumber = 0;
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] > maxNumber)
//            {
//                maxNumber = array[i];
//            }
//        }
//        Console.WriteLine(maxNumber);
//    }
//}

//PROBLEM SET 3
//1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

//using System;
//using System.Collections.Generic;

//class MainClass
//{
//    static void Main()
//    {
//        // create the string list instance
//        List<string> namesInput = new List<string>();

//        // get user input
//        Console.WriteLine("Please enter a first name. When done press enter.");
//        string input = Console.ReadLine();

//        // add user input to the namesInput list
//        namesInput.Add(input);

//        Console.WriteLine(input + " added to the names list");

//        while (input != "")
//        {
//            Console.WriteLine("Please enter another first name");
//            input = Console.ReadLine();
//            namesInput.Add(input);

//            if (input != "")
//            {
//                Console.WriteLine(input + " added to the names list");
//            }

//        }


//        if (namesInput.Count == 2)
//        {
//            Console.WriteLine(namesInput[0] + " liked your post");

//        } else if (namesInput.Count == 3)
//        {
//            Console.WriteLine("{0}, and {1} like your post", namesInput[0], namesInput[1]);
//        } else if (namesInput.Count > 3)
//        {
//            Console.WriteLine("{0},{1} and " + (namesInput.Count - 3) + "others like your post", namesInput[0], namesInput[1]);
//        }

//    }
//}



//2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

//using System;

//class MainClass
//{

//    // Main Method 
//    public static void Main()
//    {
//        Console.WriteLine("Please enter your name");

//        string name = Console.ReadLine();

//        char[] charArray = name.ToCharArray();
//        Array.Reverse(charArray);
//        Console.WriteLine(charArray);
//    }
//}


//3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
//using System;
//using System.Collections.Generic;

//class MainClass
//{
//    static void Main()
//    {
//        var numbersTaken = 0;
//        List<string> numberInput = new List<string>();
//        while (numbersTaken <= 4)
//        {
//            Console.WriteLine("Please enter a number: ");
//            string input = Console.ReadLine();

//            if (numberInput.Contains(input))
//            {
//                Console.WriteLine("You have already entered that number, please enter a unique number: ");
//                string inputUnique = Console.ReadLine();
//                numberInput.Add(inputUnique);

//                Console.WriteLine(inputUnique + " added to the number list");

//                numbersTaken++;
//            }
//            else
//            {
//                numberInput.Add(input);

//                Console.WriteLine(input + " added to the number list");

//                numbersTaken++;
//            }


//        }
//        numberInput.Sort();

//        for (var i = 0; i < numberInput.Count; i++)
//        {
//            Console.Write(numberInput[i]);
//        }

//    }
//}


//4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

		string number = "Go";

        List<string> numberInput = new List<string>();

        do
        {
            Console.WriteLine("Please enter a number, or type 'Quit' to exit: ");
            number = Console.ReadLine();
            numberInput.Add(number);

        }
        while (number != "Quit");

    var uniqueNumbers =
        from n in numberInput
        group n by n into nGroup
        where nGroup.Count() == 1
        select nGroup.Key;

        foreach (string uniqueNumber in uniqueNumbers)
        {
            Console.WriteLine(uniqueNumber);
        }
    }
}

// { 0, 1, 3, 5 }

//5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.