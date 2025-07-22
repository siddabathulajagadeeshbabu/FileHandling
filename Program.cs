using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are the steps for implementing file handling in C#:");
            //step 1:crete the System.IO namespace
            string filePath = "example.txt";
           
            try
            {
                File.WriteAllText(filePath, "Hello World!, This is a first file created using C# file handling.");
                Console.WriteLine("File created and writteb successfully");

                string content = File.ReadAllText(filePath);
                Console.WriteLine("file content: " + content);
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine("File not found: " + fnfEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("An I/O error occurred: " + ioEx.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine("Access to the file is denied: " + uaEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + Ex.Message);
            }
            finally
            {
                Console.WriteLine("File handling operation completed.");
            }
        }
    }
}
