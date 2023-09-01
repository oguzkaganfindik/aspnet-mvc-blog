using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class Page
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Sayfa başlığı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Sayfa başlığı en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
