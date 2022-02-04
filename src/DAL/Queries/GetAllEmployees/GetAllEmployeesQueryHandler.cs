using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryHandler : IQueryHandler<GetAllEmployeesQuery, IList<Employee>>
    {
        private readonly BuildingContext _buildingContext;
        public GetAllEmployeesQueryHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task<IList<Employee>> HandleAsync(GetAllEmployeesQuery query, CancellationToken cancellationToken = default)
        {
            List<Employee> employees = await _buildingContext.Employees.ToListAsync(cancellationToken);

            return employees;
        }
    }
}
