using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.Models
{
    public class User : Controller
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string FullName { get; set; } // Üye adı ve soyadı
        public string Email { get; set; } // Üye e-posta adresi
        public string Password { get; set; } // Üye giriş parolası
        public string PhoneNumber { get; set; } // Üye telefon numarası
        public DateTime JoinDate { get; set; } // Üye kayıt tarihi
    }
}
