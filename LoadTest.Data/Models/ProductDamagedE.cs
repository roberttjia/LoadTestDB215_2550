using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ProductDamagedE
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int ProductStockId { get; set; }

        public virtual ProductE Product { get; set; } = null!;
        public virtual ProductStockE ProductStock { get; set; } = null!;
    }
}