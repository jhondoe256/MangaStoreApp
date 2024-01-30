using System.ComponentModel.DataAnnotations;
using MangaHut.Models.ViewModels.Locations;

namespace MangaHut.Models.ViewModels.Stores
{
    public class Store_location_Create
    {
        public string Name { get; set; } = "Manga Hut";
        
        public LocationCreate Location { get; set; }
    }
}