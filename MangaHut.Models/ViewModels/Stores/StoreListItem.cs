using MangaHut.Models.ViewModels.Locations;

namespace MangaHut.Models.ViewModels.Stores
{
    public class StoreListItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public LocationListItem Location { get; set; } = new LocationListItem();
    }
}