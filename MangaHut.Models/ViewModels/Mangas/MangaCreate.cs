namespace MangaHut.Models.ViewModels.Mangas
{
    public class MangaCreate
    {
        public string Author { get; set; } 
        public string Title { get; set; } 
        public decimal Price { get; set; } 
        public int ItemCount { get; set; }
    }
}