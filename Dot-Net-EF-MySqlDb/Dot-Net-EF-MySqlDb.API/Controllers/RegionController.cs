using Dot_Net_EF_MySqlDb.API.Models.Domain;
using Dot_Net_EF_MySqlDb.API.Models.DTO;
using Dot_Net_EF_MySqlDb.API.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

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
            var regions = await regionRepository.GetAllRegionAsync();
            List<GetRegionDto> regionsDto = new List<GetRegionDto>();

            if (ModelState.IsValid)
            {
                foreach (var region in regions)
                {
                    regionsDto.Add(new GetRegionDto
                    {
                        Code = region.Code,
                        Name = region.Name,
                        RegionImageUrl = region.RegionImageUrl
                    });
                }
            }

            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetRegionById([FromRoute]string Id)
        {
            var foundRegion= await regionRepository.GetRegionById(Id);
    
            if(foundRegion == null) 
            {
                return NotFound("Please Check Region!!");
            }

            return Ok(new GetRegionDto
            {
                Code=foundRegion.Code,
                Name=foundRegion.Name,
                RegionImageUrl=foundRegion.RegionImageUrl
            });
        }

        [HttpPost]
        [Route("CreateRegion")]
        public async Task<IActionResult> CreateRegion(GetRegionDto regionDto)
        {
            //mapping DTO to Domain class
            Region region=new Region()
            {

                RegionImageUrl = regionDto.RegionImageUrl,
                Code=regionDto.Code,
                Name=regionDto.Name
            };
            return Ok(await regionRepository.Createregion(region));
        }

        [HttpPut(template:"UpdateRegion")]
        public async Task<IActionResult> UpdateRegion([FromBody] UpdateRegionDto updatatedRegionDetails)
        {
            Region region = new Region()
            {
                Code = updatatedRegionDetails.Code,
                Name = updatatedRegionDetails.Name,
                RegionImageUrl = updatatedRegionDetails.RegionImageUrl
            };

             return Ok(await regionRepository.Updateregion(updatatedRegionDetails.Id, region));
        }

        [HttpDelete(template:"DeleteRoute")]
        public async Task<IActionResult> DeleteRegion([FromBody] string Id)
        {
           return Ok(await regionRepository.Deleteregion(Id));
        }

    }
}
