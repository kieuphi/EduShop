using System.ComponentModel.DataAnnotations;

namespace EduShop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}