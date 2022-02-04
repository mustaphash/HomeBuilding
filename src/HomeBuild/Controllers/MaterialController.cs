using Core.Entity;
using Core.Queries;
using DAL.Queries.GetAllMaterials;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("materials")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IQueryHandler<GetAllMaterialsQuery, IList<Material>> _getAllMaterialsQuery;
        public MaterialController(
            IQueryHandler<GetAllMaterialsQuery, IList<Material>> getAllMaterialsQuery)
        {
            _getAllMaterialsQuery = getAllMaterialsQuery;
        }

        [HttpGet(Name = "GetAllMaterials")]
        public async Task<IActionResult> GetAllMaterials()
        {
            IList<Material> materials = await _getAllMaterialsQuery.HandleAsync(new GetAllMaterialsQuery());

            return Ok(materials);
        }
    }
}
