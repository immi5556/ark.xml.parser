using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ark.Xml.Parser
{
    class ArkXml
    {
        static void Info(string msg)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void Error(Exception exp)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exp);
            Console.ResetColor();
        }
        string _content;
        XDocument doc = null;
        void Validate(string content)
        {
            try
            {
                doc = XDocument.Parse(content);
            }
            catch (System.Xml.XmlException xexp)
            {
                Error(xexp);
                return;
            }
        }
        public void Add(string ele)
        {
            doc.Root.Add(XElement.Parse(ele));
        }
        public override string ToString()
        {
            return doc.ToString();
        }
        public bool EnableInfo { get; set; } = true;
        public ArkXml(string content)
        {
            Validate(content);
            _content = content;
            Info($"Received Content : {Environment.NewLine}{content}");
        }
    }
}
