using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class AccountE
    {
        public AccountE()
        {
            AccountDeposit = new HashSet<AccountDepositE>();
            AccountWithdraw = new HashSet<AccountWithdrawE>();
            SellingPayment = new HashSet<SellingPaymentE>();
            PurchasePayment = new HashSet<PurchasePaymentE>();
            Expense = new HashSet<ExpenseE>();
            ExpenseTransportation = new HashSet<ExpenseTransportationE>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordE>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordE>();
            SellingExpense = new HashSet<SellingExpenseE>();
        }
        
        public int AccountEId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public decimal CostPercentage { get; set; }
        
        public virtual InstitutionE? Institution { get; set; }
        public virtual ICollection<AccountWithdrawE> AccountWithdraw { get; set; }
        public virtual ICollection<AccountDepositE> AccountDeposit { get; set; }
        public virtual ICollection<SellingPaymentE> SellingPayment { get; set; }
        public virtual ICollection<PurchasePaymentE> PurchasePayment { get; set; }
        public virtual ICollection<ExpenseE> Expense { get; set; }
        public virtual ICollection<ExpenseTransportationE> ExpenseTransportation { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordE> SellingPaymentReturnRecord { get; set; }
        public virtual ICollection<SellingExpenseE> SellingExpense { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordE> PurchasePaymentReturnRecord { get; set; }
    }
}
