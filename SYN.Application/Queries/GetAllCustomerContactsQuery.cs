using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

using SYN.Application.Queries;
using SYN.Domain.Entities;
using SYN.Domain.Interfaces;

namespace SYN.Application.Queries
{
    public record GetAllCustomerContactsQuery : IRequest<IEnumerable<CustomerContactsEntity>>;
    public class GetAllCustomerContactsQueryHandler(ICustomerContactsRepository customerContactsRepository) : IRequestHandler<GetAllCustomerContactsQuery, IEnumerable<CustomerContactsEntity>>
    {
        public async Task<IEnumerable<CustomerContactsEntity>> Handle(GetAllCustomerContactsQuery request, CancellationToken cancellationToken)
        {
            return await customerContactsRepository.GetCustomerContacts();
        }
    }
}