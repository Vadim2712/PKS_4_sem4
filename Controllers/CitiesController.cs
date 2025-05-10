using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TouristGuideApp.Data;
using TouristGuideApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace TouristGuideApp.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cities (Главная страница со списком городов и поиском)
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString; // Для отображения текущего поискового запроса в поле

            var citiesQuery = from c in _context.Cities
                              select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                citiesQuery = citiesQuery.Where(s => s.Name.Contains(searchString) ||
                                                     (s.Region != null && s.Region.Contains(searchString)));
            }

            var cities = await citiesQuery.AsNoTracking().ToListAsync();
            return View(cities);
        }

        // GET: Cities/Details/5 (Информация о городе)
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Attractions) // Включаем связанные достопримечательности
                .AsNoTracking() // Используем для запросов только на чтение для повышения производительности
                .FirstOrDefaultAsync(m => m.Id == id);

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // CRUD операции (Create, Edit, Delete) можно добавить аналогично,
        // используя скаффолдинг или написав их вручную, если это входит в задачу.
        // Для данного ТЗ они не являются первостепенными, но для полноты приложения могут быть полезны.
    }
}