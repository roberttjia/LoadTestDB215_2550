using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class VendorE
    {
        public VendorE()
        {
            Purchase = new HashSet<PurchaseE>();
            PurchasePayment = new HashSet<PurchasePaymentE>();
        }

        public int VendorEId { get; set; }
        public string VendorCompanyName { get; set; } = string.Empty;
        public string VendorName { get; set; } = string.Empty;
        public string VendorAddress { get; set; } = string.Empty;
        public string VendorPhone { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal ReturnAmount { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ICollection<PurchaseE> Purchase { get; set; }
        public virtual ICollection<PurchasePaymentE> PurchasePayment { get; set; }
    }
}
