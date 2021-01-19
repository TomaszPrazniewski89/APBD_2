using APBD_2.Classes; //inna siezka gdyz zmienilem nazwe z Classes na Models
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace APBD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Getting the parameters



            //2. Loading the data from CSV
            // te klasy za pomoca using wyzwalaja metode dispose( ktora zwalnia zasoby)
            string args1 = args[0];
            using (StreamReader reader = new StreamReader("dane.csv"))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Student student = new Student();
                //powiadomienie biblioteki ze pierwszy naglowek nie zawiera nazwl kolumn
                csv.Configuration.HasHeaderRecord = false;
                                        //metoda ktora wczytuje dane i probouje je parsowac na kalse Student, (ToList) wynik w postaci kolekci typu lista
                List<Student> records = csv.GetRecords<Student>().ToList();

            }

            //3. Save CSV into XML

            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("uczelnia"));
            serializer.Serialize(writer, records);
            writer.Close();

            //4. Save CSV into json
            string jsonString = System.Text.Json.JsonSerializer.Serialize(records);
            File.WriteAllText("data.json", jsonString);
        }
    }
}
