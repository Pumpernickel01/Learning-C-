using System;

namespace Code;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); // Write to the console (string)

        Console.Beep(); // Make a beep sound

        // This is a basic comment

        /*
            This is a multi-line comment
        */

        Console.WriteLine("\tHello!"); // How to write escape sequences

        Console.ReadKey(); // Wait for a key press

        int x = 5; // Declare an integer variable
        int y; // Declare an integer variable
        y = 10; // Assign a value to a variable

        int z = x + y; // Add two variables together

        Console.WriteLine(z); // Write the value of a variable to the console

        int age = 18; // Declare an integer variable

        Console.WriteLine("Your age is: " + age); // Concatenate a string with a variable

        double pi = 3.14159; // Declare a double variable

        bool isTrue = true; // Declare a boolean variable

        char letter = 'A'; // Declare a character 
        
        string name = "John"; // Declare a string variable

        string userName = name + letter; // Concatenate a string with a character

        Console.WriteLine(userName); // Write the value of a variable to the console


    }
}
