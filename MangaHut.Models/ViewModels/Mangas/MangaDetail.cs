namespace MangaHut.Models.ViewModels.Mangas
{
    public class MangaDetail
    {
         public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; } = 3.99m;
        public int ItemCount { get; set; } = 100;
    }
}