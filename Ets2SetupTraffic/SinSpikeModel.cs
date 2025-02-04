namespace Ets2SetupTraffic
{
    public class SinSpikeModel
    {
        public SinSpikeGenericModel Truck { get; set; }
        public SinSpikeGenericModel Bus { get; set; }
        public SinSpikeGenericModel Car { get; set; }
        //public int TruckMinSpeed { get; set; }
        //public int TruckMaxSpeed { get; set; }
        //public int TruckMinCriticalSpeed { get; set; }
        //public double TruckSpikeFactor { get; set; }
        //public double TruckSpikeZone { get; set; }
        //public int TruckCycleMultiplier { get; set; }

        //public int CarMinSpeed { get; set; }
        //public int CarMaxSpeed { get; set; }
        //public int CarMinCriticalSpeed { get; set; }
        //public int BusMinSpeed { get; set; }
        //public int BusMaxSpeed { get; set; }

        //public int BusMinCriticalSpeed { get; set; }
    }
    public class SinSpikeGenericModel
    {
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public int MinCriticalSpeed { get; set; }
        public double SpikeFactor { get; set; }
        public double SpikeZone { get; set; }
        public int CycleMultiplier { get; set; }
    }
}
