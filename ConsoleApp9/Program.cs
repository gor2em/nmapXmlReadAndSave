using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            string dosya = @"out.xml";
            xmldoc.Load(dosya);
            xmldoc.Save(Console.Out);
            xmldoc.Save("test.xml");
            Console.ReadKey();
        }
    }
}
