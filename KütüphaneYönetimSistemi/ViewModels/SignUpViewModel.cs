using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.ViewModels
{
    public class SignUpViewModel : Controller
    {
        public string FullName { get; set; } // Üye adı ve soyadı
        public string Email { get; set; } // Üye e-posta adresi
        public string Password { get; set; } // Üye giriş parolası
        public string ConfirmPassword { get; set; } // Şifre tekrar
    }
}
