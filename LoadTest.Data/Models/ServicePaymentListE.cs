using System;

namespace LoadTest.Data.Models
{
    public class ServicePaymentListE
    {
        public int ServicePaymentListEId { get; set; }
        public int ServiceEId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ServiceE Service { get; set; } = null!;
    }
}
