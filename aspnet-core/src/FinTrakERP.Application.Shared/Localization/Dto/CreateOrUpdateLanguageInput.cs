using System.ComponentModel.DataAnnotations;

namespace FinTrakERP.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}