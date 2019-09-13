using System;
using System.IO;
using System.Text;

namespace Exercise_26
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                Console.WriteLine("Please select a number: ");
                string input = Console.ReadLine();
                File.WriteAllText(@"C:\Users\16313\Desktop\C#\Exercises\log.txt", input);
                
                //Pass the file path and file name to the StreamReader constructor
                StreamReader file = new StreamReader(@"C:\Users\16313\Desktop\C#\Exercises\log.txt");

                //Read the first line of text
                line = file.ReadLine();
                Console.WriteLine("The following text has been logged into log.txt");

                //Continue until you've reached the end of the file
                while (line != null)
                {
                    //write the line to console
                    Console.WriteLine(line);
                    //Read the next line
                    line = file.ReadLine();
                }
            }
            catch
            { }
        }
    }
}
