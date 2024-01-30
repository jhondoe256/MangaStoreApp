using System.ComponentModel.DataAnnotations;

namespace MangaHut.Models.ViewModels.Stores
{
    public class Store_location_Create
    {
        public string Name { get; set; } = "Manga Hut";
        
        [MaxLength(150, ErrorMessage = "Cannot exceed 150 characters.")]
        [MinLength(10, ErrorMessage = "Must have more than 10 characters.")]
        public string Address { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "Cannot exceed 100 characters.")]
        [MinLength(3, ErrorMessage = "Must have more than 3 characters.")]
        public string City { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "Cannot exceed 100 characters.")]
        [MinLength(3, ErrorMessage = "Must have more than 3 characters.")]
        public string State { get; set; } = string.Empty;

        [MaxLength(20, ErrorMessage = "Cannot exceed 20 characters.")]
        [MinLength(5, ErrorMessage = "Must have more than 5 characters.")]
        public string ZipCode { get; set; } = string.Empty;
    }
}