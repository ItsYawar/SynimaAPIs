using System.ComponentModel.DataAnnotations;

namespace SYN.Domain.Entities
{
    public class CustomerContactsEntity
    {
        [Key]
        public long CustomerContactId { get; set; }
        public string? ContactKey { get; set; } =  null!;
        public string? ContactValue { get; set; } = null!;
        public long CustomerId { get; set; }
        //public bool IsActive { get; set; }
        //public string? CreatedBy { get; set; } = null!;
        //public DateTime CreatedOn { get; set; }
        //public string? ModifiedBy { get; set; } = null!;
        //public DateTime ModifiedOn { get; set; }
    }
}
 