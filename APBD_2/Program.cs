using System;
using System.IO;

namespace APBD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the parameters



            //Loading the data from CSV
            // te klasy za pomoca using wyzwalaja metode dispose( ktora zwalnia zasoby)
            string args1 = args[0];
            StreamReader reader = new StreamReader("dane.csv");
            //CsvReader scv = new CsvReader(reader,CultureInfo.InvariantCulture)

            Console.WriteLine("Hello World!");
        }
    }
}
