using System.ComponentModel.DataAnnotations;

namespace Backend.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}