using System;

namespace LoadTest.Data.Models
{
    public class AccountDepositE
    {
        public int AccountDepositEId { get; set; }
        public int AccountEId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DepositDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string TransactionReference { get; set; } = string.Empty;

        public virtual AccountE Account { get; set; } = null!;
    }
}
