using Microsoft.AspNetCore.Mvc;
using BlogWebsite.Data;
using BlogWebsite.Models;
using System.Linq;

namespace BlogWebsite.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.Posts.OrderByDescending(p => p.CreatedAt).ToList();
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }
    }
}