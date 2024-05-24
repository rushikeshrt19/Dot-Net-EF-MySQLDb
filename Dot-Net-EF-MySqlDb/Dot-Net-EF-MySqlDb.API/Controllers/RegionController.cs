using Dot_Net_EF_MySqlDb.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dot_Net_EF_MySqlDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private ApplicationDbontext _applicationDbontext;

        public RegionController(ApplicationDbontext applicationDbontext)
        {
            _applicationDbontext = applicationDbontext;
        }
    }
}
