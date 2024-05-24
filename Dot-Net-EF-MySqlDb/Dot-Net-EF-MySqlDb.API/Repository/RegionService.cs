using Dot_Net_EF_MySqlDb.API.Models;
using Dot_Net_EF_MySqlDb.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Dot_Net_EF_MySqlDb.API.Repository
{
    public class RegionService : IRegionRepository
    {
        private readonly ApplicationDbontext _applicationDbontext;

        public RegionService(ApplicationDbontext applicationDbontext)
        {
            _applicationDbontext = applicationDbontext;
        }

        public string Createregion(Region region)
        {
            throw new NotImplementedException();
        }

        public string Deleteregion(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Region>> GetAllRegionAsync()
        {
            return await _applicationDbontext.Region.ToListAsync();
        }

        public Task<Region> GetRegionById(string Id)
        {
            throw new NotImplementedException();
        }

        public string Updateregion(Region region)
        {
            throw new NotImplementedException();
        }
    }
}
