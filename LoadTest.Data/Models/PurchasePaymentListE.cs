using System;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentListE
    {
        public int PurchasePaymentListEId { get; set; }
        public int PurchasePaymentEId { get; set; }
        public int PurchaseEId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }

        public virtual PurchasePaymentE PurchasePayment { get; set; } = null!;
        public virtual PurchaseE Purchase { get; set; } = null!;
    }
}
