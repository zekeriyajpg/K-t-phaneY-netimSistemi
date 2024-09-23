using Microsoft.AspNetCore.Mvc;
using KütüphaneYönetimSistemi.Models;
using KütüphaneYönetimSistemi.ViewModels;

public class BookController : Controller
{
    public static List<BookViewModel> _books = new List<BookViewModel>()
{
    new BookViewModel { Id = 1, Title = "To Kill a Mockingbird", AuthorId = 1, Genre = "Fiction", PublishDate = new DateTime(1960, 7, 11), ISBN = "978-0-06-112008-4", CopiesAvailable = 5 },
    new BookViewModel { Id = 2, Title = "1984", AuthorId = 2, Genre = "Dystopian", PublishDate = new DateTime(1949, 6, 8), ISBN = "978-0-452-28423-4", CopiesAvailable = 3 },
    new BookViewModel { Id = 3, Title = "The Great Gatsby", AuthorId = 3, Genre = "Classic", PublishDate = new DateTime(1925, 4, 10), ISBN = "978-0-7432-7356-5", CopiesAvailable = 7 },
    new BookViewModel { Id = 4, Title = "Moby Dick", AuthorId = 4, Genre = "Adventure", PublishDate = new DateTime(1851, 10, 18), ISBN = "978-0-14-243724-7", CopiesAvailable = 2 },
    new BookViewModel { Id = 5, Title = "Pride and Prejudice", AuthorId = 5, Genre = "Romance", PublishDate = new DateTime(1813, 1, 28), ISBN = "978-0-19-953556-9", CopiesAvailable = 6 },
    new BookViewModel { Id = 6, Title = "The Catcher in the Rye", AuthorId = 6, Genre = "Fiction", PublishDate = new DateTime(1951, 7, 16), ISBN = "978-0-316-76948-0", CopiesAvailable = 4 },
    new BookViewModel { Id = 7, Title = "The Hobbit", AuthorId = 7, Genre = "Fantasy", PublishDate = new DateTime(1937, 9, 21), ISBN = "978-0-618-00221-3", CopiesAvailable = 8 },
    new BookViewModel { Id = 8, Title = "Fahrenheit 451", AuthorId = 8, Genre = "Dystopian", PublishDate = new DateTime(1953, 10, 19), ISBN = "978-1-4516-7331-9", CopiesAvailable = 3 },
    new BookViewModel { Id = 9, Title = "Brave New World", AuthorId = 9, Genre = "Science Fiction", PublishDate = new DateTime(1932, 8, 30), ISBN = "978-0-06-085052-4", CopiesAvailable = 4 },
    new BookViewModel { Id = 10, Title = "The Lord of the Rings", AuthorId = 7, Genre = "Fantasy", PublishDate = new DateTime(1954, 7, 29), ISBN = "978-0-618-00222-0", CopiesAvailable = 9 }
};
    public static List<AuthorViewModel> _authors = new List<AuthorViewModel>()
{
    new AuthorViewModel { Id = 1, FirstName = "Harper", LastName = "Lee", DateOfBirth = new DateTime(1926, 4, 28) },
    new AuthorViewModel { Id = 2, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
    new AuthorViewModel { Id = 3, FirstName = "F. Scott", LastName = "Fitzgerald", DateOfBirth = new DateTime(1896, 9, 24) },
    new AuthorViewModel { Id = 4, FirstName = "Herman", LastName = "Melville", DateOfBirth = new DateTime(1819, 8, 1) },
    new AuthorViewModel { Id = 5, FirstName = "Jane", LastName = "Austen", DateOfBirth = new DateTime(1775, 12, 16) },
    new AuthorViewModel { Id = 6, FirstName = "J.D.", LastName = "Salinger", DateOfBirth = new DateTime(1919, 1, 1) },
    new AuthorViewModel { Id = 7, FirstName = "J.R.R.", LastName = "Tolkien", DateOfBirth = new DateTime(1892, 1, 3) },
    new AuthorViewModel { Id = 8, FirstName = "Ray", LastName = "Bradbury", DateOfBirth = new DateTime(1920, 8, 22) },
};

    // Kitap listesini gösterir.
    public IActionResult List()
    {
        var viewModel = _books.Where(x => x.IsDeleted == false)
           .Join(
           _authors,
           book => book.AuthorId,
           author => author.Id,
           (book, author) => new { book, author }
           )
           .Select(x => new BookViewModel
           {
               Id = x.book.Id,
               Title = x.book.Title,
               AuthorId = x.book.AuthorId,
               Genre = x.book.Genre,
               AuthorName = x.author.FirstName + x.author.LastName


           }).ToList();


        return View(viewModel);
    }


    // Belirli bir kitabın detaylarını gösterir.
    public IActionResult Details(int id)
    {
        // Kitap detaylarını çek ve view'a gönder
        // Örnek: var book = db.Books.Find(id);
        return View();
    }

    // Yeni kitap eklemek için form sağlar.
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            // Kitap ekleme işlemi
            // Örnek: db.Books.Add(book); db.SaveChanges();
            return RedirectToAction("List");
        }
        return View(book);
    }

    // Var olan bir kitabı düzenlemek için form sağlar.
    public IActionResult Edit(int id)
    {
        // Kitap detaylarını çek ve form için gönder
        // Örnek: var book = db.Books.Find(id);
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Book book)
    {
        if (ModelState.IsValid)
        {
            // Kitap güncelleme işlemi
            // Örnek: db.Books.Update(book); db.SaveChanges();
            return RedirectToAction("List");
        }
        return View(book);
    }

    // Kitabı silmek için bir onay sayfası sağlar.
    public IActionResult Delete(int id)
    {
        // Silme onay sayfası
        // Örnek: var book = db.Books.Find(id);
        return View();
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        // Kitabı silme işlemi
        // Örnek: var book = db.Books.Find(id); db.Books.Remove(book); db.SaveChanges();
        return RedirectToAction("List");
    }
}
