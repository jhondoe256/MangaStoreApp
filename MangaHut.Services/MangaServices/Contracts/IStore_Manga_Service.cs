using MangaHut.Models.ViewModels.Store_Manga;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IStore_Manga_Service
    {
         Task<bool> AddManga(Store_Manga_Create model);
    }
}