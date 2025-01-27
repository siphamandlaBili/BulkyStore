﻿
using Bulky.Models.Models;
using BulkyBooks.Data;
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
        [HttpPost]
        public IActionResult Create(CategoryModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id <= 0)
            {
                return NotFound();
            }
            
            CategoryModel singleCategoryToBeEdited = _db.categories.Find(id);

            if (singleCategoryToBeEdited == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public object? Edit(CategoryModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Update(obj);
                _db.SaveChanges();
                TempData["succses"] = "Category edited succsessfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Category not edited succsessfully";
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            CategoryModel singleCategoryToBeEdited = _db.categories.Find(id);

            if (singleCategoryToBeEdited == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteCartegory(int? id)
        {
            CategoryModel singleCategoryToBeDleted = _db.categories.Find(id);
            _db.categories.Remove(singleCategoryToBeDleted);

            _db.categories.Remove(singleCategoryToBeDleted);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
