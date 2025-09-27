using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductStockE
    {
        public ProductStockE()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentE>();
            ProductLog = new HashSet<ProductLogE>();
            Warranty = new HashSet<WarrantyE>();
        }

        public int ProductStockEId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public int ProductEId { get; set; }
        public int? SellingListId { get; set; }
        public int PurchaseListEId { get; set; }
        public bool IsSold { get; set; }
        
        public virtual ProductE Product { get; set; } = null!;
        public virtual SellingListE? SellingList { get; set; }
        public virtual PurchaseListE PurchaseList { get; set; } = null!;
        public virtual ProductDamagedE? ProductDamaged { get; set; }
        public virtual ICollection<SellingAdjustmentE> SellingAdjustment { get; set; }
        public virtual ICollection<ProductLogE> ProductLog { get; set; }
        public virtual ICollection<WarrantyE> Warranty { get; set; }
    }
}
