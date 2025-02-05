using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SYN.Application.Commands;
using SYN.Application.Commands.BusinessCards;
using SYN.Application.DTOs;
using SYN.Application.Queries;
using SYN.Domain.Entities;

namespace Synima.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(ISender sender) : ControllerBase
    {
        [HttpGet ("GetAllContacts")]
        public async Task<IActionResult> GetAllCustomersAsync()
        {
            var result = await sender.Send(new GetAllCustomerContactsQuery());
            return Ok(result);
        }

        [HttpPost("AddCustomerContacts")]
        public async Task<IActionResult> AddCustomerAsync([FromBody] AddCustomerContactsRequest request)
        {
            var command = new AddCustomerContactsCommand(request.CustomerId, request.Contacts);
            var result = await sender.Send(command);
            return Ok(result);
        }
    }
}
