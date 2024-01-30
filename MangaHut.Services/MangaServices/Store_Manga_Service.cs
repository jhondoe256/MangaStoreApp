using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.ViewModels.Store_Manga;
using MangaHut.Services.MangaServices.Contracts;

namespace MangaHut.Services.MangaServices
{
    public class Store_Manga_Service : IStore_Manga_Service
    {
        private readonly ApplicationDbContext _context;

        public Store_Manga_Service(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddManga(Store_Manga_Create model)
        {
            var entity = new StoreManga
            {
                StoreId = model.StoreId,
                MangaId = model.MangaId
            };

            await _context.StoreMangas.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

    }
}