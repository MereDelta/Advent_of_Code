using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace A01
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPart = new firstPart();
            firstPart.process();

            var secondPart = new secondPart();
            secondPart.process();
        }
    }
}
