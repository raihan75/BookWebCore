using BookWebCore.Data;
using BookWebCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContex _db;
        public CategoryController(ApplicationDBContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCatoryList = _db.Categories.ToList();
            return View(objCatoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
