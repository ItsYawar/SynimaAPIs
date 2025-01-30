using MediatR;
using SYN.Domain.Entities;
using SYN.Domain.Interfaces;

namespace SYN.Application.Queries
{
    public record GetAllEmployeeQuery : IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHandler(IEmployeeRepositories employeeRepositories) :
        IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepositories.GetEmployees();
        }
    }
}
