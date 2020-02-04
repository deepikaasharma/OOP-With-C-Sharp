namespace Phones
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        public abstract void DisplayInfo();
        public string VersionNumber {get {return _versionNumber;}}
        public int BatteryPercentage {get {return _batteryPercentage;}}
        public string Carrier {get {return _carrier;}}
        public string RingTone {get {return _ringTone;}}
    }
}