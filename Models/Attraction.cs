using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristGuideApp.Models
{
    public class Attraction
    {
        public int Id { get; set; } // Первичный ключ

        [Required(ErrorMessage = "Название достопримечательности обязательно")]
        [Display(Name = "Название достопримечательности")]
        public string Name { get; set; }

        [Display(Name = "Краткое описание")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "История")]
        [DataType(DataType.MultilineText)]
        public string? History { get; set; }

        [Display(Name = "URL фотографии")]
        public string? PhotoImageUrl { get; set; } // Путь к файлу или URL

        [Display(Name = "Часы работы")]
        public string? OpeningHours { get; set; }

        [Display(Name = "Стоимость посещения")]
        [Column(TypeName = "decimal(18, 2)")] // Для корректного хранения денежных значений в БД
        public decimal? TicketPrice { get; set; } // Nullable, если бесплатно или цена не указана

        // Внешний ключ для связи с городом
        public int CityId { get; set; }

        // Навигационное свойство к городу
        [ForeignKey("CityId")]
        public virtual City? City { get; set; }
    }
}