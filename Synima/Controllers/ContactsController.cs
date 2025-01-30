using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SYN.Application.Commands;
using SYN.Application.DTOs;
using SYN.Application.Queries;

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
    }
}
