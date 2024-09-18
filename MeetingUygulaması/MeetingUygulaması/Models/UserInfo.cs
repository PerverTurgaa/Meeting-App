using System.ComponentModel.DataAnnotations;

namespace MeetingUygulaması.Models
{
    // Bu sınıfta apply actionında yazdığım formun içinden gerekenleri sınıfta tutuyoruz
    // Apply action ınnın HttpPost una bu sınıfı bind edicez
    // apply cshtml de tag helpers ilişkilendirmelerini yapıcaz
    public class UserInfo
    {       
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunlu")]

        public string? Name { get; set; } // null  değer kabul etmesi gerekiyor
      
        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        public string? Phone {  get; set; }
        
        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress(ErrorMessage = "Hatalı Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumunuz alanı zorunlu")]
        public bool? WillAttend { get; set; } // true false null
    }
}
