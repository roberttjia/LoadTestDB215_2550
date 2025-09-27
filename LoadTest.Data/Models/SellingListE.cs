using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class SellingListE
    {
        public SellingListE()
        {
            ProductStock = new HashSet<ProductStockE>();
        }

        public int SellingListEId { get; set; }
        public int SellingEId { get; set; }
        public int ProductEId { get; set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        
        public virtual SellingE Selling { get; set; } = null!;
        public virtual ProductE Product { get; set; } = null!;
        public virtual ICollection<ProductStockE> ProductStock { get; set; }
    }
}
