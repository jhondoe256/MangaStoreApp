using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.ViewModels.Locations;
using MangaHut.Models.ViewModels.Stores;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MangaHut.Services.MangaServices
{
    public class StoreService : IStoreService
    {
        private readonly ApplicationDbContext _context;

        public StoreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddStore_Location(Store_location_Create model)
        {
            Store entity = new Store
            {
                Name = model.Name
            };

            await _context.Stores.AddAsync(entity);
            await _context.SaveChangesAsync();

            Location locationModel = new Location
            {
                Address = model.Location.Address,
                City = model.Location.City,
                State = model.Location.State,
                ZipCode = model.Location.ZipCode,
                StoreId = entity.Id
            };

            await _context.AddAsync(locationModel);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EditStore(StoreEdit model)
        {
            Store storeInDb = await _context.Stores.FindAsync(model.Id);
            if (storeInDb is null)
            {
                return false;
            }
            storeInDb.Name = model.Name;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<StoreDetail> GetStore(int id)
        {
            Store storeInDb =
            await
            _context
            .Stores
            .Include(s => s.Location)
            .SingleOrDefaultAsync(x => x.Id == id);

            if (storeInDb is null)
            {
                return null;
            }
            return new StoreDetail
            {
                Id = storeInDb.Id,
                Name = storeInDb.Name,
                Location = new LocationListItem
                {
                    Id = storeInDb.Location.Id,
                    Address = storeInDb.Location.Address,
                    ZipCode = storeInDb.Location.ZipCode
                }
            };
        }

        public async Task<List<StoreListItem>> GetStores()
        {
            return await _context.Stores.Include(s => s.Location).Select(s => new StoreListItem
            {
                Id = s.Id,
                Name = s.Name,
                Location = new LocationListItem
                {
                    Id = s.Location.Id,
                    Address = s.Location.Address,
                    ZipCode = s.Location.ZipCode
                }

            }).ToListAsync();
        }

    }
}