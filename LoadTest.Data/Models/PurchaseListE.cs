using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchaseListE
    {
        public PurchaseListE()
        {
            ProductStock = new HashSet<ProductStockE>();
        }
        
        public int PurchaseListEId { get; set; }
        public int PurchaseEId { get; set; }
        public int ProductEId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        
        public virtual PurchaseE Purchase { get; set; } = null!;
        public virtual ProductE Product { get; set; } = null!;
        public virtual ICollection<ProductStockE> ProductStock { get; set; }
    }
}
