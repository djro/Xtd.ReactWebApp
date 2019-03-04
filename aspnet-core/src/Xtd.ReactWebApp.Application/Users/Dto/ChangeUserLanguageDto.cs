using System.ComponentModel.DataAnnotations;

namespace Xtd.ReactWebApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}