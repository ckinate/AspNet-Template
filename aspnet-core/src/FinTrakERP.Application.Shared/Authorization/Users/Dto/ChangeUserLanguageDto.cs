using System.ComponentModel.DataAnnotations;

namespace FinTrakERP.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
