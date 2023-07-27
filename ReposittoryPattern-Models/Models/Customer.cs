namespace ReposittoryPattern_Models.Models
{
    public class Customer : AuditableBaseEntity
    {
        public string Address { get; set; } 
        public string PhoneNumber { get; set; }
    }
}
