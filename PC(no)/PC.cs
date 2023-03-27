using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_no_
{
    class VideoCard
    {
        public void Start() => Console.WriteLine("VideoCard starts up");
        public void CheckMonitorConnection() => Console.WriteLine("VideoCard checked monitor connection");
        public void RAMInfo() => Console.WriteLine("VideoCard prints RAM info");
        public void DiscReaderInfo() => Console.WriteLine("Disc Reader Info");
        public void HDDInfo() => Console.WriteLine("VideoCard prints HDD info");

        //OFF
        public void ShowFarewellMessage() => Console.WriteLine("Monitor shows: Farewell, user!");

    }
    class RAM
    {
        public void Start() => Console.WriteLine("RAM starts up");
        public void Analyze() => Console.WriteLine("RAM analyzes something...");

        //OFF
        public void ClearRAM() => Console.WriteLine("Clearing RAM...");
    }

    class HDD
    {
        public void Start() => Console.WriteLine("HDD starts up");
        public void Analyze() => Console.WriteLine("HDD analyzes itself..");

        //OFF
        public void Stop() => Console.WriteLine("HDD stops");
    }

    class DiscReader
    {
        public void Start() => Console.WriteLine("Disc Reader starts up");
        public void CheckDisk() => Console.WriteLine("Disc Reader checks disk");
    }

    class PU
    {
        public void ApplyPower() => Console.WriteLine("PU applies power");
        public void ApplyPowerOnVideocard() => Console.WriteLine("Pu applies power on videocard");
        public void ApplyPowerOnRAM() => Console.WriteLine("Pu applies power on RAM");
        public void ApplyPowerOnDiscReader() => Console.WriteLine("Pu applies power on Disk Reader");
        public void ApplyPowerOnDiscHDD() => Console.WriteLine("Pu applies power on HDD");

        //OFF

        public void CutVideocardPower() => Console.WriteLine("PU cuts VideoCard power");
        public void CutRAMPower() => Console.WriteLine("PU cuts RAM power");
        public void CutDiskReaderPower() => Console.WriteLine("PU cuts Disk Reader power");
        public void CutHDDPower() => Console.WriteLine("PU cuts HDD power");
        public void Stop() => Console.WriteLine("PU turns OFF");
    }
    
    class Sensor
    {
        public void CheckVoltage() => Console.WriteLine("Sensors check voltage");
        public void CheckTemperature() => Console.WriteLine("Sensosrs check temperature");
        public void CheckVideoCardTemperature() => Console.WriteLine("Sensors check Video Card temperature");
        public void CheckRAMTemperature() => Console.WriteLine("Sensors check RAM temperature");
        public void CheckAllSystemTemperature() => Console.WriteLine("Sensors check All system temperature");

    }
}
