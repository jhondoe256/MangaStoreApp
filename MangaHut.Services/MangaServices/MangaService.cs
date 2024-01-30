using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.ViewModels.Mangas;
using MangaHut.Services.MangaServices.Contracts;

namespace MangaHut.Services.MangaServices
{
    public class MangaService : IMangaService
    {
        private readonly ApplicationDbContext _context;

        public MangaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddManga(MangaCreate model)
        {
            var entity = new Manga
            {
                Author = model.Author,
                Title = model.Title,
                Price = model.Price,
                ItemCount = model.ItemCount
            };

            await _context.Mangas.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<MangaDetail> GetManga(int id)
        {
            var mangaInDb = await _context.Mangas.FindAsync(id);
            if(mangaInDb is null) return null;

            return new MangaDetail
            {
                Id = mangaInDb.Id,
                Author = mangaInDb.Author,
                Title = mangaInDb.Title,
                Price = mangaInDb.Price,
                ItemCount = mangaInDb.ItemCount
            };
        }

    }
}