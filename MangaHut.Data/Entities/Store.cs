using System.ComponentModel.DataAnnotations;

namespace MangaHut.Data.Entities
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public virtual Location Location { get; set; }
        public string Name { get; set; } = "Manga Hut";
    }
}