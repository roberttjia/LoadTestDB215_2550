using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ExpenseCategoryE
    {
        public ExpenseCategoryE()
        {
            Expense = new HashSet<ExpenseE>();
        }

        public int ExpenseCategoryEId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ExpenseE> Expense { get; set; }
    }
}
