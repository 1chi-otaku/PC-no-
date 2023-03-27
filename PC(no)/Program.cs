using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PC_no_
{
    class Facade
    {
        VideoCard videocard { get; set; }
        RAM RAM { get; set; }
        HDD HDD { get; set; }
        DiscReader discReader { get; set; }
        PU PU { get; set; }
        Sensor sensors { get; set; }
        public Facade(VideoCard videocard, RAM rAM, HDD hDD, DiscReader discReader, PU pU, Sensor sensors)
        {
            this.videocard = videocard;
            RAM = rAM;
            HDD = hDD;
            this.discReader = discReader;
            PU = pU;
            this.sensors = sensors;
        }

        public void PC_ON()
        {
            PU.ApplyPower();
            sensors.CheckVoltage();
            sensors.CheckTemperature();
            sensors.CheckVideoCardTemperature();
            PU.ApplyPowerOnVideocard();
            videocard.Start();
            videocard.CheckMonitorConnection();
            sensors.CheckRAMTemperature();
            PU.ApplyPowerOnRAM();
            RAM.Start();
            RAM.Analyze();
            videocard.RAMInfo();
            PU.ApplyPowerOnDiscReader();
            discReader.Start();
            discReader.CheckDisk();
            videocard.DiscReaderInfo();
            PU.ApplyPowerOnDiscHDD();
            HDD.Start();
            HDD.Analyze();
            videocard.HDDInfo();
            sensors.CheckAllSystemTemperature();
            Console.WriteLine("PC is turned on now!");
        }
        
        public void PC_OFF()
        {
            HDD.Stop();
            RAM.ClearRAM();
            RAM.Analyze();
            videocard.ShowFarewellMessage();
            PU.CutVideocardPower();
            PU.CutRAMPower();
            PU.CutDiskReaderPower();
            PU.CutHDDPower();
            sensors.CheckVoltage();
            PU.Stop();
        }



        //ON OFF
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoCard videoCard = new VideoCard();
            RAM RAM = new RAM();
            HDD HDD = new HDD();
            DiscReader discReader = new DiscReader();
            PU PU = new PU();
            Sensor sensor = new Sensor();

            Facade PC = new Facade(videoCard,RAM,HDD,discReader,PU,sensor);

            PC.PC_ON();
            Console.WriteLine();
            PC.PC_OFF();
        }
    }
}
