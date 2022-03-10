using Core.Commands;

namespace DAL.Commands
{
    public class CreateEmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand>
    {
        private readonly BuildingContext _buildingContext;
        public CreateEmployeeCommandHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task HandleAsync(CreateEmployeeCommand command, CancellationToken cancellationToken = default)
        {
            await _buildingContext.AddAsync(command.Employee);
            await _buildingContext.SaveChangesAsync();
        }
    }
}
