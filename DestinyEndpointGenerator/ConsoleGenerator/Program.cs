using DestinyEndpointGenerator.EndpointGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenerator
{
    class Program
    {

        static Generator _Generator = new Generator();

        static void Main(string[] args)
        {

            _Generator.LoadApiDocsAsync(); //Totally okay




            var startMessage = "A tool for generating C# classes with access to the Destiny 2 Api.";
            Console.Title = startMessage;
            Console.WriteLine(startMessage);

            Console.WriteLine("\nPress any key to begin generating the library.");
            Console.ReadLine();

            if (_Generator.ModelIsLoaded)
            {
                CreateFile();
            }
            else {
                Console.WriteLine("Waiting for model to load.");
                while (!_Generator.ModelIsLoaded) { }
                CreateFile();
                
            }

            Console.WriteLine("Finished saving file.");

            Console.WriteLine("Press any key to exit the program");
            Console.ReadLine();

        }

        static void CreateFile()
        {
            var fileData = _Generator.GenerateClassLibraryAsync().Result;

            File.WriteAllText(@"C:\Users\Bailey Miller\Desktop\ClassLibrary.cs", fileData, Encoding.UTF8);
            
        }
    }
}
