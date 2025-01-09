using BulkyRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyRazor.Pages.Cat
{
    
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<CategoryModel> categoryList {get; set;}
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            categoryList = _db.category.ToList();
        }
    }
}
