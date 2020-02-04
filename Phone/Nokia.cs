using System;

namespace Phones
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring()
        {
            return $"... { RingTone } ...";
        }
        public string Unlock()
        {
            return $"Nokia { VersionNumber } unlocked with passcode";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Nokia { VersionNumber }");
            Console.WriteLine($"Battery Percentage: { BatteryPercentage }");
            Console.WriteLine($"Carrier: { Carrier }");
            Console.WriteLine($"Ring Tone: { RingTone }");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("");
        }
    }
}