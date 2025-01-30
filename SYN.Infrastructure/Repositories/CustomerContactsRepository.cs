using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SYN.Domain.Entities;
using SYN.Domain.Interfaces;
using SYN.Infrastructure.Data;

namespace SYN.Infrastructure.Repositories
{
    public class CustomerContactsRepository(SynDBContext dbContext) : ICustomerContactsRepository
    {
        public async Task<IEnumerable<CustomerContactsEntity>> GetCustomerContacts()
        {
            return await dbContext.CustomerContacts.ToListAsync();
        }
    }
}
