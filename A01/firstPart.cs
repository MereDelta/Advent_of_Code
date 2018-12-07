using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace A01
{
    public class firstPart
    {
        public void process()
        {
            string[] filePaths = Directory.GetFiles(Environment.CurrentDirectory, "*.csv", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Path: {filePaths[0]}\r\n");

            int frequenzy = 0;
            using (var reader = new StreamReader(filePaths[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    frequenzy += int.Parse(line);                    
                }
            }
            Console.WriteLine($"Resulting frequenzy: {frequenzy}");
        }
    }
}