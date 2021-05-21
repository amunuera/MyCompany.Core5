using System.ComponentModel.DataAnnotations;

namespace MyCompany.Core5.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}