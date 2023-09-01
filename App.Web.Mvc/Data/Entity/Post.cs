using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class Post
    {
        public int CategoryId;

        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur.")]
        [MaxLength(200, ErrorMessage = "Başlık en fazla 200 karakter olmalıdır.")]
        public string Title { get; set; }

        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Yayın Tarihi")]
        public DateTime PublishDate { get; set; }
    }
}
