using MangaHut.Models.ViewModels.Stores;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IStoreService
    {
       Task<bool> AddStore_Location(Store_location_Create model);
       Task<StoreDetail> GetStore(int id);
       Task<bool> EditStore(StoreEdit model); 
       Task<List<StoreListItem>> GetStores(); 
    }
}