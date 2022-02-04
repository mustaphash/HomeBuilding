using Core.Entity;
using Core.Queries;
using DAL.Queries.GetAllPlaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("places")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPlacesQuery, IList<Place>> _getAllPlaceQuery;
        public PlaceController(
            IQueryHandler<GetAllPlacesQuery, IList<Place>> getAllPlaceQuery)
        {
            _getAllPlaceQuery = getAllPlaceQuery;
        }

        [HttpGet(Name = "GetAllPlaces")]
        public async Task<IActionResult> GetAllPlaces()
        {
            IList<Place> places = await _getAllPlaceQuery.HandleAsync(new GetAllPlacesQuery());

            return Ok(places);
        }
    }
}
