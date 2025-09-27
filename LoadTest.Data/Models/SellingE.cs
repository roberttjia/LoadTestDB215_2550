using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class SellingE
    {
        public SellingE()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentE>();
            SellingList = new HashSet<SellingListE>();
            SellingPaymentList = new HashSet<SellingPaymentListE>();
            SellingExpense = new HashSet<SellingExpenseE>();
            Warranty = new HashSet<WarrantyE>();
            ProductLog = new HashSet<ProductLogE>();
            SellingPromiseDateMisses = new HashSet<SellingPromiseDateMissE>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordE>();
        }

        public int SellingEId { get; set; }
        public int RegistrationEId { get; set; }
        public int CustomerEId { get; set; }
        public int SellingSn { get; set; }
        public decimal SellingTotalPrice { get; set; }
        public decimal SellingDiscountAmount { get; set; }
        public decimal SellingDiscountPercentage { get; set; }
        public decimal SellingPaidAmount { get; set; }
        public decimal SellingReturnAmount { get; set; }
        public decimal SellingDueAmount { get; set; }
        public string SellingPaymentStatus { get; set; } = string.Empty;
        public DateTime SellingDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? PromisedPaymentDate { get; set; }
        public string SellingNotes { get; set; } = string.Empty;
        public decimal ServiceCharge { get; set; }
        public decimal ServiceCost { get; set; }
        public string ServiceChargeDescription { get; set; } = string.Empty;
        public decimal ExpenseTotal { get; set; }
        public decimal AccountTransactionCharge { get; set; }
        public decimal BuyingTotalPrice { get; set; }
        public decimal SellingAccountCost { get; set; }
        public decimal ServiceProfit { get; set; }
        public decimal SellingProfit { get; set; }
        public decimal SellingNetProfit { get; set; }
        public decimal GrandProfit { get; set; }
        public decimal PurchaseAdjustedAmount { get; set; }
        public string PurchaseDescription { get; set; } = string.Empty;
        public int? PurchaseId { get; set; }

        public virtual CustomerE Customer { get; set; } = null!;
        public virtual RegistrationE Registration { get; set; } = null!;
        public virtual PurchaseE? Purchase { get; set; }
        public virtual ICollection<SellingAdjustmentE> SellingAdjustment { get; set; }
        public virtual ICollection<SellingListE> SellingList { get; set; }
        public virtual ICollection<SellingPaymentListE> SellingPaymentList { get; set; }
        public virtual ICollection<SellingExpenseE> SellingExpense { get; set; }
        public virtual ICollection<WarrantyE> Warranty { get; set; }
        public virtual ICollection<ProductLogE> ProductLog { get; set; }
        public virtual ICollection<SellingPromiseDateMissE> SellingPromiseDateMisses { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordE> SellingPaymentReturnRecord { get; set; }
    }
}
