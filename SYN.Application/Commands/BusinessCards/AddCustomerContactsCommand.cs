using MediatR;

using SYN.Application.DTOs;
using SYN.Domain.Entities;
using SYN.Domain.Interfaces;
 
namespace SYN.Application.Commands.BusinessCards
{
    public class CustomerContactDto
    {
        public string ContactKey { get; set; } = string.Empty;
        public string ContactValue { get; set; } = string.Empty;
    }
    public record AddCustomerContactsCommand(long CustomerId, List<CustomerContactDto> Contacts) : IRequest<bool>;

   // public record CustomerContactDto(string ContactKey, string ContactValue);

    public class AddCustomerContactsHandler : IRequestHandler<AddCustomerContactsCommand, bool>
    {
        private readonly ICustomerContactsRepository _repository;

        public AddCustomerContactsHandler(ICustomerContactsRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(AddCustomerContactsCommand request, CancellationToken cancellationToken)
        {
            var contacts = request.Contacts.Select(c => new CustomerContactsEntity
            {
                CustomerId = request.CustomerId,
                ContactKey = c.ContactKey,
                ContactValue = c.ContactValue,
            }).ToList();

            return await _repository.AddCustomerContactsAsync(contacts);
        }
    }

    //public record AddCustomerContactsCommand(CustomerContactsEntity customerContactsEntity) : IRequest<CustomerContactsEntity>;

    //public class AddCustomerContactsCommandHandler(ICustomerContactsRepository customerContactsRepository) 
    //    : IRequestHandler<AddCustomerContactsCommand, CustomerContactsEntity>
    //{
    //    public async Task<CustomerContactsEntity> Handle(AddCustomerContactsCommand request, CancellationToken cancellationToken)
    //    {
    //        return await customerContactsRepository.AddCustomerContactsAsync(request.customerContactsEntity);
    //    }

    //}
}
