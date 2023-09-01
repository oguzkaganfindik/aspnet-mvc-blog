using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Web.Mvc.Data.Entity
{
    public class PostImage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Dosya adı zorunludur.")]
        [MaxLength(255, ErrorMessage = "Dosya adı en fazla 255 karakter olmalıdır.")]
        public string FileName { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
