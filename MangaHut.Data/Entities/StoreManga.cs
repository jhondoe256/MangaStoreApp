using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaHut.Data.Entities
{
    public class StoreManga
    {
        [Key]
        public int Id { get; set; }
        
        public int StoreId { get; set; }
        
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }
        
        public int MangaId { get; set; }

        [ForeignKey(nameof(MangaId))]
        public Manga Manga { get; set; }
    }
}