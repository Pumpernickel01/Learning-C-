using System;

namespace Code;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!"); // Write to the console (string)

        // Console.Beep(); // Make a beep sound

        // // This is a basic comment

        // /*
        //     This is a multi-line comment
        // */

        // Console.WriteLine("\tHello!"); // How to write escape sequences

        // //Console.ReadKey(); // Wait for a key press

        // int x = 5; // Declare an integer variable
        // int y; // Declare an integer variable
        // y = 10; // Assign a value to a variable

        // int z = x + y; // Add two variables together

        // Console.WriteLine(z); // Write the value of a variable to the console

        // int age = 18; // Declare an integer variable

        // Console.WriteLine("Your age is: " + age); // Concatenate a string with a variable

        // //double pi = 3.14159; // Declare a double variable

        // bool isTrue = true; // Declare a boolean variable
        // Console.WriteLine(isTrue); // Write the value of a variable to the console

        // char letter = 'A'; // Declare a character 
        
        // string name = "John"; // Declare a string variable

        // string userName = name + letter; // Concatenate a string with a character
        // Console.WriteLine(userName); // Write the value of a variable to the console


        // // Constants are immutable values that are known at compile time and do not change for the life of the program
        // const double pi = 3.14159; // Declare a double variable
        // //pi = 420;
        // Console.WriteLine(pi); // Write the value of a variable to the console

        
        // // Type casting are used to convert a variable from one data type to another data type
        // double myDouble = 3.14; // Declare a double variable
        // int b = Convert.ToInt32(myDouble); // Convert a double to an integer
        // int myInt = (int)myDouble; // Cast a double to an integer

        // Console.WriteLine(b); // Write the value of a variable to the console
        // Console.WriteLine(myInt); // Write the value of a variable to the console
        // Console.WriteLine(myInt.GetType()); // Write the value of a variable to the console and get the type of the variable

        // int c = 10; // Declare an integer variable
        // string f = Convert.ToString(c); // Convert an integer to a string
        // Console.WriteLine(f); // Write the value of a variable to the console
        // Console.WriteLine(f.GetType()); // Write the value of a variable to the console and get the type of the variable


        //User input
        Console.WriteLine("Enter your name: "); // Write to the console
        string name = Console.ReadLine(); // Read a line of text from the console
        System.Console.WriteLine("Hello, " + name); // Concatenate a string with a variable
    }
}
