using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.Models
{
    public class Author : Controller
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string FirstName { get; set; } // Yazarın adı
        public string LastName { get; set; } // Yazarın soyadı
        public DateTime DateOfBirth { get; set; } // Doğum tarihi
    }
}
