using ReposittoryPattern_Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReposittoryPattern_Models.Models
{
    public class Product : AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public Status ProductStatus { get; set; }

        public ProductCategories ProductCategories { get; set; }

        public string ProductCategoriesDesc
        {
            set
            {
                ProductCategories.ToString();
            }
        }
    }
}
