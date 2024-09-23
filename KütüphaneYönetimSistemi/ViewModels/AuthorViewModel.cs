using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.ViewModels
{
    public class AuthorViewModel : Controller
    {
        public int Id { get; set; } // Yazar kimliği
        /*public string FullName => $"{FirstName} {LastName}";*/ // Yazarın tam adı
        public string FirstName { get; set; } // Yazarın adı
        public string LastName { get; set; } // Yazarın soyadı
        public DateTime DateOfBirth { get; set; } // Doğum tarihi
    }
}

