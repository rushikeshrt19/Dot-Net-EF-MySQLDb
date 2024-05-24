using Dot_Net_EF_MySqlDb.API.Models;
using Dot_Net_EF_MySqlDb.API.Models.Domain;
using Microsoft.AspNetCore.Mvc.Controllers;
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

        public async Task<string> Createregion(Region region)
        {
            Guid guid = Guid.NewGuid();
            region.Id=guid.ToString();
            await _applicationDbontext.Region.AddAsync(region);
            var code = await _applicationDbontext.SaveChangesAsync();

            if (code == 1)
            {
                return "New Region Added Successfully!!";
            }
            else
            {
                return "Please Check Data!!";
            }
        }

        public async Task<string> Deleteregion(string Id)
        {
            Region? foundRegion= await _applicationDbontext.Region.FirstOrDefaultAsync(x => x.Id==Id);

            if (foundRegion != null) 
            { 
                _applicationDbontext.Region.Remove(foundRegion);
                
                await _applicationDbontext.SaveChangesAsync();

                return "Region Deleted Successfully!!";
            }
            else
            {
                return "Region Not Found!!";
            }
        }

        public async Task<List<Region>> GetAllRegionAsync()
        {
            return await _applicationDbontext.Region.ToListAsync();
        }

        public async Task<Region> GetRegionById(string Id)
        {
            return _applicationDbontext.Region.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<string> Updateregion(string Id,Region region)
        {
            Region? foundRegion= await _applicationDbontext.Region.FirstOrDefaultAsync(x => x.Id == Id);

            if(foundRegion == null)
            {
                return "Region Not Found!!";
            }
            else
            {
                foundRegion.Name = region.Name;
                foundRegion.RegionImageUrl = region.RegionImageUrl;
                foundRegion.Code = region.Code;

                int code= await _applicationDbontext.SaveChangesAsync();

                if(code == 1)
                {
                    return "Region Updated Successfully!!";
                }
                else 
                {
                    return "Region Not Updated";                
                }
            }
        }
    }
}
