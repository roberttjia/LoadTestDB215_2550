using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class PurchasePaymentReturnRecordE
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public int PurchaseId { get; set; }
        public int AccountId { get; set; }

        public virtual PurchaseE Purchase { get; set; } = null!;
        public virtual AccountE Account { get; set; } = null!;
    }
}