using System;

namespace LoadTest.Data.Models
{
    public class SellingAdjustmentE
    {
        public int SellingAdjustmentEId { get; set; }
        public int SellingEId { get; set; }
        public int ProductEId { get; set; }
        public int ProductStockEId { get; set; }
        public string AdjustmentType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime AdjustmentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string ApprovedBy { get; set; } = string.Empty;

        public virtual SellingE Selling { get; set; } = null!;
        public virtual ProductE Product { get; set; } = null!;
        public virtual ProductStockE ProductStock { get; set; } = null!;
    }
}
