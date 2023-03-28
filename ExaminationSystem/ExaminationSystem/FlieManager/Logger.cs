using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.FlieManager
{
    internal static class Logger
    {
        // Set a variable to the Documents path.
        static string docPath =
          Directory.GetCurrentDirectory();
        public static void Log(string fileName, string input, bool append = false)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{fileName}.txt"), append))
            {

                outputFile.WriteLine(input);
            }
        }
        public static Dictionary<string, string> ReadFile(string fileName,string fileExtention)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader($"{fileName}{fileExtention}.txt"))
                {
                    string[] line = sr.ReadToEnd().Split(';');
                    string lineID = line[0];
                    string lineContent = line[1];
                    // Read the stream as a string, and write the string to the console.
                    result.Add(lineID, lineContent);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return result;
        }

    }
}
