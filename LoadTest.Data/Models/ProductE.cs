using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductE
    {
        public ProductE()
        {
            ProductStock = new HashSet<ProductStockE>();
            SellingAdjustment = new HashSet<SellingAdjustmentE>();
            PurchaseList = new HashSet<PurchaseListE>();
            SellingList = new HashSet<SellingListE>();
        }

        public int ProductEId { get; set; }
        public int ProductCatalogEId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public DateTime InsertDate { get; set; }
        
        public virtual ProductCatalogE ProductCatalog { get; set; } = null!;
        public virtual ICollection<ProductStockE> ProductStock { get; set; }
        public virtual ICollection<SellingAdjustmentE> SellingAdjustment { get; set; }
        public virtual ICollection<PurchaseListE> PurchaseList { get; set; }
        public virtual ICollection<SellingListE> SellingList { get; set; }
    }
}
