using System.ComponentModel.DataAnnotations;

namespace ReposittoryPattern_Models.Models
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set;}
    }
}
