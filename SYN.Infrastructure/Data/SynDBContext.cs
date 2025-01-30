using Microsoft.EntityFrameworkCore;
using SYN.Domain.Entities;


namespace SYN.Infrastructure.Data
{
     public class SynDBContext(DbContextOptions<SynDBContext> options) : DbContext(options)
    //public class SynDBContext : DbContext
    {
        //public SynDBContext(DbContextOptions<SynDBContext> options) : base(options) { }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<FormElement> FormElements { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<CustomerContactsEntity> CustomerContacts { get; set; }
    }
}
     
