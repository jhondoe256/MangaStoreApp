using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaHut.Data.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(150,ErrorMessage ="Cannot exceed 150 characters.")]
        [MinLength(10,ErrorMessage ="Must have more than 10 characters.")]
        public string Address { get; set; }= string.Empty;

        [MaxLength(100,ErrorMessage ="Cannot exceed 100 characters.")]
        [MinLength(3,ErrorMessage ="Must have more than 3 characters.")]
        public string City { get; set; }= string.Empty;

        [MaxLength(100,ErrorMessage ="Cannot exceed 100 characters.")]
        [MinLength(3,ErrorMessage ="Must have more than 3 characters.")]
        public string State { get; set; }= string.Empty;
        
        [MaxLength(20,ErrorMessage ="Cannot exceed 20 characters.")]
        [MinLength(5,ErrorMessage ="Must have more than 5 characters.")]
        public string ZipCode { get; set; }= string.Empty;
        
        public int StoreId { get; set; }
        
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }
    }
}