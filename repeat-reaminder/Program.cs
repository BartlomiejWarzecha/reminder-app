using System;
using System.IO;
using System.Windows;

namespace repeat_reaminder
{
    class Program
    {
        public static void Main()
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader("test.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
