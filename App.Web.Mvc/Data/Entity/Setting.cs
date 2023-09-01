using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class Setting
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Setting key zorunludur.")]
        public string Key { get; set; }

        [Required(ErrorMessage = "Setting değeri zorunludur.")]
        public string Value { get; set; }
    }
}
