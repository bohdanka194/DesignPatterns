using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TripLaptopBuilder : LaptopBuilder
    {
        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "256 Gb";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "16 Gb";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1200x780";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Intel Core i3-7100, 2.4GHz";
        }
    }
}
