using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.webp",
                    Price = 100000,
                    TotalPage = 480,
                    Sumary = "",
                },
                new Book()
                {
                    Id = 2,
                    Title = "Lão Hạc",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/products/b2.webp",
                    Price = 210000,
                    TotalPage = 300,
                    Sumary = "",
                },
                new Book()
                {
                    Id = 3,
                    Title = "Dế Mèn Phiêu Lưu Ký",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/products/b3.webp",
                    Price = 95000,
                    TotalPage = 52,
                    Sumary = "",
                },
                new Book()
                {
                    Id = 4,
                    Title = "Đường xưa mây trắng",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/images/products/b4.webp",
                    Price = 60000,
                    TotalPage = 200,
                    Sumary = "",
                }
            };

            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = GetBookList().Find(x => x.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Ngô Tất Tố"},
            new SelectListItem {Value = "3", Text = "Tô Hoài"},
            new SelectListItem {Value = "4", Text = "Thiền sư Thích Nhất Hạnh"}
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh"},
            new SelectListItem {Value = "2", Text = "Văn học đương đại"},
            new SelectListItem {Value = "3", Text = "Truyện cười"},
            new SelectListItem {Value = "4", Text = "Truyện cười"}
        };
    }
}