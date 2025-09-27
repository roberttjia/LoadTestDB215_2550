using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ExpenseFixedE
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int ExpenseCategoryId { get; set; }

        public virtual ExpenseCategoryE ExpenseCategory { get; set; } = null!;
    }
}