using MangaHut.Models.ViewModels.Mangas;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IMangaService
    {
        Task<bool> AddManga(MangaCreate model);
        Task<MangaDetail> GetManga(int id);
    }
}