using MangaHut.Models.ViewModels.Locations;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface ILocationService
    {
        Task<bool> AddLocation(LocationCreate model);
        Task<LocationDetail> GetLocation(int id);
        Task<List<LocationListItem>> GetLocations();
    }
}