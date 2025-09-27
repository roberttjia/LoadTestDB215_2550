using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class PurchaseE
    {
        public PurchaseE()
        {
            PurchaseList = new HashSet<PurchaseListE>();
            PurchasePaymentList = new HashSet<PurchasePaymentListE>();
            ProductLog = new HashSet<ProductLogE>();
            Selling = new HashSet<SellingE>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordE>();
        }

        public int Id { get; set; }
        public string PurchaseNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
        public int VendorId { get; set; }
        public int RegistrationId { get; set; }

        public virtual VendorE Vendor { get; set; } = null!;
        public virtual RegistrationE Registration { get; set; } = null!;
        public virtual ICollection<PurchaseListE> PurchaseList { get; set; }
        public virtual ICollection<PurchasePaymentListE> PurchasePaymentList { get; set; }
        public virtual ICollection<ProductLogE> ProductLog { get; set; }
        public virtual ICollection<SellingE> Selling { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordE> PurchasePaymentReturnRecord { get; set; }
    }
}