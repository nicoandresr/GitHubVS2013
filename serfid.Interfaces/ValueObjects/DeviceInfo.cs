using System;

namespace serfid.Interfaces.ValueObjects
{
    public class DeviceInfo
    {
        public string Tag { get; set; }
        public string Device { get; set; }
        public string Detail { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
