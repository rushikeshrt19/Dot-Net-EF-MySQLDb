using Dot_Net_EF_MySqlDb.API.Models.Domain;

namespace Dot_Net_EF_MySqlDb.API.Repository
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllRegionAsync();

        Task<Region> GetRegionById(string Id);

        string Createregion(Region region);

        string Updateregion(Region region);

        string Deleteregion(string Id);
    }
}
