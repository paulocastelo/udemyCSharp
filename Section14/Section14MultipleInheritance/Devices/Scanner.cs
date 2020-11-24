using System;
namespace Section14MultipleInheritance.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing:" + document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
