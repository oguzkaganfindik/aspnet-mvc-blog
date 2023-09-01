using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Data.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [MaxLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
    }
}
