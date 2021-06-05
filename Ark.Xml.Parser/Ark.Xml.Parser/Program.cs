using System;

namespace Ark.Xml.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cont = "invalid xml";
            string file_name = args != null && args.Length > 0 ? args[0] : "csproj_xml1.xml";
            string cont = System.IO.File.ReadAllText(file_name);
            var tg = new Ark.Xml.Parser.ArkXml(cont);
            tg.Add("<ItemGroup><Compile Remove=\"Migrations\\**\" /><EmbeddedResource Remove = \"Migrations\\**\" /><None Remove = \"Migrations\\**\" /></ItemGroup>");
            System.IO.File.WriteAllText(file_name, tg.ToString());
            //Console.WriteLine(tg.ToString());
        }
    }
}
