namespace Login.Models
{
    public class AuditableEntity:BaseEntity
    {
        public DateTime CreatedAt {  get; set; }

        public Guid? CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid? UpdatedBy { get; set;}

        public Guid? Modify { get; set; }

        public bool IsDeleted { get; set; }
    }
}
