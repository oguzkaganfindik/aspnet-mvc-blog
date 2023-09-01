using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class PostComment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Yorum içeriği zorunludur.")]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Yorum Tarihi")]
        public DateTime CommentDate { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
