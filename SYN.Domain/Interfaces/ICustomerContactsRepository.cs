using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SYN.Domain.Entities;

namespace SYN.Domain.Interfaces
{
    public interface ICustomerContactsRepository
    {
        Task<IEnumerable<CustomerContactsEntity>> GetCustomerContacts();
        //Task<CustomerContacts> GetCustomerContactByIdAsync(long id);
        //Task<CustomerContacts> AddCustomerContactAsync(CustomerContacts customerContacts);
        //Task<CustomerContacts> UpdateCustomerContactAsync(long customerContactId, CustomerContacts customerContacts);
        //Task<bool> DeleteCustomerContactAsync(long customerContactId);
    }
}
