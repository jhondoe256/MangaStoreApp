using MangaHut.Models.ViewModels.Stores;

namespace MangaHut.Models.ViewModels.Locations
{
    public class LocationDetail
    {
        public int Id { get; set; }
               
        public string Address { get; set; }= string.Empty;

        public string City { get; set; }= string.Empty;

        public string State { get; set; }= string.Empty;
   
        public string ZipCode { get; set; }= string.Empty;
        
        public StoreListItem Store { get; set; }
    }
}