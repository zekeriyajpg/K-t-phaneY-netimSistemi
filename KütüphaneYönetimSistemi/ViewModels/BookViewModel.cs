using Microsoft.AspNetCore.Mvc;

namespace KütüphaneYönetimSistemi.ViewModels
{
    public class BookViewModel : Controller
    {
        public bool IsDeleted { get; set; }
        public int AuthorId { get; set; }
        public int Id { get; set; } // Kitap kimliği
        public string Title { get; set; } // Kitap başlığı
        public string AuthorName { get; set; } // Yazar adı
        public string Genre { get; set; } // Kitap türü
        public DateTime PublishDate { get; set; } // Yayın tarihi
        public string ISBN { get; set; } // ISBN numarası
        public int CopiesAvailable { get; set; } // Mevcut kopya sayısı
    }
}
