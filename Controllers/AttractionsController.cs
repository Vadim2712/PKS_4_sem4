﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TouristGuideApp.Data;
using TouristGuideApp.Models;
using System.Threading.Tasks;

namespace TouristGuideApp.Controllers
{
    public class AttractionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttractionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Attractions/Details/5 (Информация о достопримечательности)
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attraction = await _context.Attractions
                .Include(a => a.City) // Включаем информацию о городе, к которому относится достопримечательность
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (attraction == null)
            {
                return NotFound();
            }

            return View(attraction);
        }
        // CRUD операции для достопримечательностей также можно добавить при необходимости.
    }
}