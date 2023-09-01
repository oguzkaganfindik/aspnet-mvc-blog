using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class CategoryPost
    {
        public int CategoryId { get; set; }
        public int PostId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
