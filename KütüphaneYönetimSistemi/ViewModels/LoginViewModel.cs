using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.ViewModels
{
    public class LoginViewModel : Controller
    {
        public string Email { get; set; } // Üye e-posta adresi
        public string Password { get; set; } // Üye giriş parolası
    }
}
