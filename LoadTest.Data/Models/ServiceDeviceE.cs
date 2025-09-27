using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ServiceDeviceE
    {
        public int Id { get; set; }
        public string DeviceName { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
        public int CustomerId { get; set; }

        public virtual CustomerE Customer { get; set; } = null!;
    }
}