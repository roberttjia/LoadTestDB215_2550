using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ProductCatalogTypeE
    {
        public ProductCatalogTypeE()
        {
            ProductCatalog = new HashSet<ProductCatalogE>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ProductCatalogE> ProductCatalog { get; set; }
    }
}