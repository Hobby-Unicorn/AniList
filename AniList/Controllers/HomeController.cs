using Anilist.Data;
using Anilist.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Anilist.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Pobierz 3 najnowsze anime
            var newestAnime = _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(3).ToList();

            // Pobierz aktualnoœci
            var newsList = _context.News.OrderByDescending(n => n.DatePosted).Take(3).ToList();

            // Przeka¿ dane do widoku
            var viewModel = new HomeIndexViewModel
            {
                NewestAnime = newestAnime,
                NewsList = newsList
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddNews(string newsTitle, string newsContent)
        {
            var news = new News
            {
                Title = newsTitle,
                Content = newsContent,

                DatePosted = DateTime.Now
            };

            _context.News.Add(news);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteNews(int newsId)
        {
            var news = await _context.News.FindAsync(newsId);
            if (news != null)
            {
                _context.News.Remove(news);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }


    }

}
