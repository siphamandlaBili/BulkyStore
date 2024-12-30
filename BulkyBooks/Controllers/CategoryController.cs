using BulkyBooks.Data;
using BulkyBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooks.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<CategoryModel> objCategoryList = _db.categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
