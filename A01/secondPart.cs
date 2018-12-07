using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace A01
{
    public class secondPart
    {
        public void process()
        {
            string[] filePaths = Directory.GetFiles(Environment.CurrentDirectory, "*.csv", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Path: {filePaths[0]}\r\n");

            List<int> duplicateList = new List<int>();
            List<int> frequenzyList = new List<int>();

            using (var reader = new StreamReader(filePaths[0]))
            {
                
                int frequenzy = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    frequenzy += int.Parse(line);

                    frequenzyList.Add(frequenzy);
                    duplicateList = frequenzyList.GroupBy(same => same).Where(item => item.Count() > 1).Select(item => item.Key).ToList();
                    if(0 < duplicateList.Count())
                        break;             
                }
            }
            try
            {
                Console.WriteLine($"Resulting frequenzy: {duplicateList[0]}");
            }
            catch(SystemException error)
            {
                Console.WriteLine($"{error}");
            }
            
        }
    }
}