using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllBrigades
{
    public class GetAllBrigadesQueryHandler : IQueryHandler<GetAllBrigadesQuery, IList<Brigade>>
    {
        private readonly BuildingContext _buildingContext;
        public GetAllBrigadesQueryHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task<IList<Brigade>> HandleAsync(GetAllBrigadesQuery query, CancellationToken cancellationToken = default)
        {
            List<Brigade> brigades = await _buildingContext.Brigades.ToListAsync(cancellationToken);

            return brigades;
        }
    }
}
