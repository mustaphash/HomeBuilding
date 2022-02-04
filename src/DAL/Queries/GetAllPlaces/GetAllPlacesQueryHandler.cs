using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllPlaces
{
    public class GetAllPlacesQueryHandler : IQueryHandler<GetAllPlacesQuery, IList<Place>>
    {
        private readonly BuildingContext _buildingContext;
        public GetAllPlacesQueryHandler(BuildingContext buildingContext)
        {
            _buildingContext = buildingContext;
        }
        public async Task<IList<Place>> HandleAsync(GetAllPlacesQuery query, CancellationToken cancellationToken = default)
        {
            List<Place> places = await _buildingContext.Places.ToListAsync(cancellationToken);

            return places;
        }
    }
}
