using System;
using KTPO4310.Shakirzanov.Lib.src.LogAn; // Make sure this is the correct namespace!

namespace KTPO4310.Shakirzanov.Service
{
    public class MainEntry
    {
        public static void Main(string[] args)
        {
            try
            {
                LogAnalyzer logAnalyzer = new LogAnalyzer();

                string[] fileNames =
                {
                    "app.log",      // Valid log file
                    "error.log",    // Valid log file
                    "data.txt",     // Invalid txt file
                    "image.jpg",    // Invalid jpg file
                    "config.ini",   // Invalid ini file
                    "file.LOG",    // Valid Log file (case insensitive)
                    "old.log.bak",   // Invalid with log inside the file name
                    ".log",         // Valid, though unusual.
                    "nolog",  // invalid
                    "notes.doc",   // invalid
                    null,           // Testing null input
                    ""              // Testing empty input
                };


                foreach (var fileName in fileNames)
                {

                    if (fileName == null)
                    {
                        Console.WriteLine($"File: 'NULL', Valid extension: False");
                        continue;
                    }
                    if (string.IsNullOrEmpty(fileName))
                    {
                        Console.WriteLine($"File: 'Empty string', Valid extension: False");
                        continue;
                    }

                    bool isValid = logAnalyzer.IsValidLogFileName(fileName);
                    Console.WriteLine($"File: '{fileName}', Valid extension: {isValid}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}