using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllMaterials
{
    public class GetAllMaterialsQueryHandler : IQueryHandler<GetAllMaterialsQuery, IList<Material>>
    {
        private readonly BuildingContext _buildingContext;
        public GetAllMaterialsQueryHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task<IList<Material>> HandleAsync(GetAllMaterialsQuery query, CancellationToken cancellationToken = default)
        {
            List<Material> materials = await _buildingContext.Materials.ToListAsync(cancellationToken);

            return materials;
        }
    }
}
