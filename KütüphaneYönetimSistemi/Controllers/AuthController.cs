using Microsoft.AspNetCore.Mvc;
using KütüphaneYönetimSistemi.Models;
using KütüphaneYönetimSistemi.ViewModels;

public class AuthController : Controller
{
    private static List<User> users = new List<User>
    {
        new User
        {
            Id = 1,
            FullName = "Örnek Kullanıcı",
            Email = "ornek@example.com",
            Password = "1234",
            PhoneNumber = "555-555-5555",
            JoinDate = DateTime.Now
        }
    };


    // Kayıt işlemini yönetir.
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(SignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Kullanıcı kaydı işlemi
            // Örnek: var user = new User { ... }; db.Users.Add(user); db.SaveChanges();
            return RedirectToAction("Login");
        }
        return View(model);
    }

    // Giriş işlemini yönetir.
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        // Kullanıcı girişi doğrulama
        // Örnek: var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        return RedirectToAction("Index", "Home"); // Giriş başarılı ise yönlendir
    }
}
