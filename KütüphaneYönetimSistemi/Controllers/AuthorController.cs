using Microsoft.AspNetCore.Mvc;
using KütüphaneYönetimSistemi.Models;
using KütüphaneYönetimSistemi.ViewModels;

public class AuthorController : Controller
{

    // Yazar listesini gösterir.
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


    public IActionResult List()
    {
        var viewModel = _authors.Select(x => new AuthorViewModel
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            DateOfBirth = x.DateOfBirth,
        }).ToList();



        return View(viewModel);

    }

    // Belirli bir yazarın detaylarını gösterir.
    public IActionResult Details(int id)
    {
        // Yazar detaylarını çek ve view'a gönder
        // Örnek: var author = db.Authors.Find(id);
        return View();
    }

    // Yeni yazar eklemek için form sağlar.
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Author author)
    {
        if (ModelState.IsValid)
        {
            // Yazar ekleme işlemi
            // Örnek: db.Authors.Add(author); db.SaveChanges();
            return RedirectToAction("List");
        }
        return View(author);
    }

    // Var olan bir yazarı düzenlemek için form sağlar.
    public IActionResult Edit(int id)
    {
        // Yazar detaylarını çek ve form için gönder
        // Örnek: var author = db.Authors.Find(id);
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        if (ModelState.IsValid)
        {
            // Yazar güncelleme işlemi
            // Örnek: db.Authors.Update(author); db.SaveChanges();
            return RedirectToAction("List");
        }
        return View(author);
    }

    // Yazarı silmek için bir onay sayfası sağlar.
    public IActionResult Delete(int id)
    {
        // Silme onay sayfası
        // Örnek: var author = db.Authors.Find(id);
        return View();
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        // Yazarı silme işlemi
        // Örnek: var author = db.Authors.Find(id); db.Authors.Remove(author); db.SaveChanges();
        return RedirectToAction("List");
    }
}
