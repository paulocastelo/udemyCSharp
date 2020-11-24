using System;
using System.Collections.Generic;
using System.Text;

namespace Section14MultipleInheritance.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
