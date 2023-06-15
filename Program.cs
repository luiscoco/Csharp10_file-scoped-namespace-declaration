using System;

namespace MyProgram
{
    // File-scoped namespace declaration
    namespace Utilities
    {
        class Helper
        {
            public static void PrintMessage()
            {
                Console.WriteLine("Hello, from the Helper class!");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Utilities.Helper.PrintMessage(); // Accessing the helper class method
        }
    }
}
