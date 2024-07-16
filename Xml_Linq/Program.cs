
using System;
using System.Linq;
using System.Xml.Linq;

namespace Xml_Linq {
    public class Program {
        static void Main(string[] args) {

            var fileName = @"C:\Users\PC-816\source\repos\Xml_Linq\Xml_Linq\Store.xml";
            var storeXml = XElement.Load(fileName);
            
            var beers = from e in storeXml.Element("beers").Elements("beer")
                        //orderby e.Value
                        orderby e.Attribute("style").Value
                        //select e;
                        select new Beer {
                            Name = e.Value,
                            Style= e.Attribute("style").Value
                        };

            foreach (var beer in beers) {
                Console.WriteLine($"The {beer.Name}\t is an {beer.Style}");
            }

            Console.ReadLine();
        }
    }

    public class Beer {
        public string Name  { get; set; }
        public string Style { get; set; }
    }
}





            //var filename = @"C:\Users\PC-816\source\repos\Xml_Linq\Xml_Linq\Store.xml";
            //XElement storeXML = XElement.Load(filename);

            //var beers = from e in storeXML.Element("beers").Elements("beer")
            //            //where e.Attribute("style").Value.Equals("porter")
            //            orderby e.Value
            //            //orderby e.Attribute("style").Value
            //            //select e;
                        
            //            select new Beer {
            //                Name= e.Value,
            //                Style=e.Attribute("style").Value
            //            };


            //foreach (var beer in beers) {
            //    Console.WriteLine($"The {beer.Name}\t is an {beer.Style}");
            //}