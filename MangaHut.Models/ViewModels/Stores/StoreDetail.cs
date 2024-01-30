using MangaHut.Models.ViewModels.Locations;

namespace MangaHut.Models.ViewModels.Stores
{
    public class StoreDetail
    {
        public int Id { get; set; }
        public LocationListItem Location { get; set; }
        public string Name { get; set; }
    }
}