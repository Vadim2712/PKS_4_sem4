using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TouristGuideApp.Models
{
    public class City
    {
        public int Id { get; set; } // Первичный ключ

        [Required(ErrorMessage = "Название города обязательно")]
        [Display(Name = "Название города")]
        public string Name { get; set; }

        [Display(Name = "Регион")]
        public string? Region { get; set; } // Nullable, если регион может отсутствовать

        [Display(Name = "Население")]
        public int? Population { get; set; } // Nullable

        [Display(Name = "История")]
        [DataType(DataType.MultilineText)]
        public string? History { get; set; }

        [Display(Name = "URL герба")]
        public string? CoatOfArmsImageUrl { get; set; } // Путь к файлу или URL

        [Display(Name = "URL фотографии")]
        public string? PhotoImageUrl { get; set; } // Путь к файлу или URL

        // Навигационное свойство для связи с достопримечательностями
        public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
    }
}