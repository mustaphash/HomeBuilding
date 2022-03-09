using Core.Entity;
using Core.Queries;
using DAL.Queries.GetAllBuildings;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("buildings")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IQueryHandler<GetAllBuildingsQuery, IList<Building>> _getAllBuildingsQuery;
        public BuildingController(
            IQueryHandler<GetAllBuildingsQuery, IList<Building>> getAllBuildingsQuery)
        {
            _getAllBuildingsQuery = getAllBuildingsQuery;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBuildings()
        {
            IList<Building> buildings = await _getAllBuildingsQuery.HandleAsync(new GetAllBuildingsQuery());

            return Ok(buildings);
        }
    }
}
