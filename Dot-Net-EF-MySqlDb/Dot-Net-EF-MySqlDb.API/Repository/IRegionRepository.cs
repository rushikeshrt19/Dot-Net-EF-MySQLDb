using Dot_Net_EF_MySqlDb.API.Models.Domain;

namespace Dot_Net_EF_MySqlDb.API.Repository
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllRegionAsync();

        Task<Region> GetRegionById(string Id);

        Task<string> Createregion(Region region);

        Task<string> Updateregion(string Id, Region region);

        Task<string> Deleteregion(string Id);
    }
}
