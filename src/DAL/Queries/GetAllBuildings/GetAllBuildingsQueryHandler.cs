using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllBuildings
{
    public class GetAllBuildingsQueryHandler : IQueryHandler<GetAllBuildingsQuery, IList<Building>>
    {
        private readonly BuildingContext _buildingContext;
        public GetAllBuildingsQueryHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task<IList<Building>> HandleAsync(GetAllBuildingsQuery query, CancellationToken cancellationToken = default)
        {
            List<Building> buildings = await _buildingContext.Buildings.ToListAsync(cancellationToken);

            return buildings;
        }
    }
}
