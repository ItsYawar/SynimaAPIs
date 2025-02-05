using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SYN.Application.Commands.BusinessCards;

namespace SYN.Application.DTOs
{
    //public class CustomerContactDto
    //{
    //    public string ContactKey { get; set; } = string.Empty;  // Ensure non-nullable
    //    public string ContactValue { get; set; } = string.Empty;
    //}

    public class AddCustomerContactsRequest
    {
        public long CustomerId { get; set; }
        public List<CustomerContactDto> Contacts { get; set; } = new();
    }
}
