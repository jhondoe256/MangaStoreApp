using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.ViewModels.Locations;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MangaHut.Services.MangaServices
{
    public class LocationService : ILocationService
    {
        private readonly ApplicationDbContext _context;

        public LocationService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<bool> AddLocation(LocationCreate model)
        {
            var entity = new Location
            {
                Address = model.Address,
                City= model.City,
                State = model.State,
                ZipCode = model.ZipCode
            };

            await _context.Locations.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<LocationDetail> GetLocation(int id)
        {
            Location locationInDb = await 
            _context
            .Locations
            .Include(l=>l.Store)
            .FirstOrDefaultAsync(x=>x.Id == id);
            
            if(locationInDb is null) return null;

            return new LocationDetail
            {
                Id = locationInDb.Id,
                Address = locationInDb.Address,
                City = locationInDb.City,
                State = locationInDb.State,
                ZipCode = locationInDb.ZipCode,
                StoreName = locationInDb.Store.Name
            };                 
        }

        public async Task<List<LocationListItem>> GetLocations()
        {
            return await _context.Locations.Select(l=> new LocationListItem{
                Id = l.Id,
                Address = l.Address,
                ZipCode = l.ZipCode
            }).ToListAsync();
        }

    }
}