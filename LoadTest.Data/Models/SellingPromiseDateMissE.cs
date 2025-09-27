using System;

namespace LoadTest.Data.Models
{
    public class SellingPromiseDateMissE
    {
        public int SellingPromiseDateMissEId { get; set; }
        public int SellingEId { get; set; }
        public DateTime PromisedDate { get; set; }
        public DateTime ActualDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;

        public virtual SellingE Selling { get; set; } = null!;
    }
}
