using ReposittoryPattern_Models.Enums;

namespace ReposittoryPattern_Models.Models
{
    public class Product : AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Status ProductStatus { get; set; }

        public ProductCategories ProductCategories { get; set; }

       /* public string ProductCategoriesDesc 
        { 
            set 
            { 
                ProductCategories.ToString(); 
            } 
        }*/
    }
}
