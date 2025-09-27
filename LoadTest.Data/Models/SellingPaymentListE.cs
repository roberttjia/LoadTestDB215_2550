using System;

namespace LoadTest.Data.Models
{
    public class SellingPaymentListE
    {
        public int SellingPaymentListEId { get; set; }
        public int SellingPaymentEId { get; set; }
        public int SellingEId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual SellingPaymentE SellingPayment { get; set; } = null!;
        public virtual SellingE Selling { get; set; } = null!;
    }
}
