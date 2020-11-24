using System;
using Section14MultipleInheritance.Devices;

namespace Section14MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My e-mail");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 159753 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
