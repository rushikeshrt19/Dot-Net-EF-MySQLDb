using Dot_Net_EF_MySqlDb.API.Models;
using Dot_Net_EF_MySqlDb.API.Models.DTO;
using Dot_Net_EF_MySqlDb.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dot_Net_EF_MySqlDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;

        public RegionController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        [Route("GetAllRegion")]
        public async Task<IActionResult> GetAllRegion()
        {
            var regions=await regionRepository.GetAllRegionAsync();
            List<GetRegionDto> regionsDto = new List<GetRegionDto>();

            if(ModelState.IsValid)
            {
               foreach(var region in regions)
                {
                    regionsDto.Add(new GetRegionDto
                    {
                         Code = region.Code,
                         Name = region.Name,
                         RegionImageUrl=region.RegionImageUrl
                    });
                }
            }

            return Ok(regionsDto);
        }

    }
}
