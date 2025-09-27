using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class SellingExpenseE
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public int SellingId { get; set; }
        public int AccountId { get; set; }

        public virtual SellingE Selling { get; set; } = null!;
        public virtual AccountE Account { get; set; } = null!;
    }
}