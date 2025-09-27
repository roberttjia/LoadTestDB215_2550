using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class CustomerPhoneE
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string PhoneType { get; set; } = string.Empty;
        public int CustomerId { get; set; }

        public virtual CustomerE Customer { get; set; } = null!;
    }
}