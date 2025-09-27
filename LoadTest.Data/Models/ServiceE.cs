using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ServiceE
    {
        public ServiceE()
        {
            ServiceList = new HashSet<ServiceListE>();
            ServicePaymentList = new HashSet<ServicePaymentListE>();
        }

        public int Id { get; set; }
        public string ServiceNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public int RegistrationId { get; set; }

        public virtual CustomerE Customer { get; set; } = null!;
        public virtual RegistrationE Registration { get; set; } = null!;
        public virtual ICollection<ServiceListE> ServiceList { get; set; }
        public virtual ICollection<ServicePaymentListE> ServicePaymentList { get; set; }
    }
}