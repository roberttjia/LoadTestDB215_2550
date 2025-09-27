using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentE
    {
        public PurchasePaymentE()
        {
            PurchasePaymentList = new HashSet<PurchasePaymentListE>();
        }

        public int PurchasePaymentEId { get; set; }
        public int VendorEId { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;

        public virtual VendorE Vendor { get; set; } = null!;
        public virtual AccountE? Account { get; set; }
        public virtual ICollection<PurchasePaymentListE> PurchasePaymentList { get; set; }
    }
}
