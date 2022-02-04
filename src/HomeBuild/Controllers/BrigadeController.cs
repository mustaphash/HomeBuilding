using Core.Entity;
using Core.Queries;
using DAL.Queries.GetAllBrigades;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("brigades")]
    [ApiController]
    public class BrigadeController : ControllerBase
    {
        private readonly IQueryHandler<GetAllBrigadesQuery, IList<Brigade>> _getAllBrigadesQuery;
        public BrigadeController(
            IQueryHandler<GetAllBrigadesQuery, IList<Brigade>> getAllBrigadesQuery)
        {
            _getAllBrigadesQuery = getAllBrigadesQuery;
        }

        [HttpGet(Name = "GetAllBrigades")]
        public async Task<IActionResult> GetAllBrigades()
        {
            IList<Brigade> brigades = await _getAllBrigadesQuery.HandleAsync(new GetAllBrigadesQuery());

            return Ok(brigades);
        }
    }
}
