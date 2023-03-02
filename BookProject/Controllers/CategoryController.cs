using BLLBookProject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;

namespace BookProject.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {

        BLLCategory bllcategory = new BLLCategory();
        public IActionResult Index()
        {
            var categoryList = bllcategory.GetCategoryList();
            return View(categoryList);
        }

        public IActionResult Details(int id)
        {
            var category = bllcategory.GetCategory(id);
            return View(category);
        }

        public IActionResult Create()
        {
            var categoryModel = new CategoryModel();
            return View(categoryModel);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            try
            {
                categoryModel = bllcategory.CreateCategory(categoryModel);
                return RedirectToAction(nameof(Index));

            }
            catch
            {

            }
            return View(categoryModel);

        }

<<<<<<< Updated upstream
        public IActionResult Edit(int id)
        {
            var updatedCategory = new CategoryModel();
            updatedCategory = bllcategory.GetCategory(id);
=======
        public IActionResult Edit(int categoryid)
        {
            var updatedCategory = new CategoryModel();
            updatedCategory=bllcategory.GetCategory(categoryid);
>>>>>>> Stashed changes
            return View(updatedCategory);
        }

        [HttpPost]
        public IActionResult Edit(int categoryId, CategoryModel updatedCategory)
        {
            try
            {
                updatedCategory = bllcategory.UpdateCategory(categoryId, updatedCategory);

            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var categoryModel = new CategoryModel();
            categoryModel = bllcategory.GetCategory(id);
            return View(categoryModel);
        }


        [HttpPost]
        public IActionResult Delete(int id, CategoryModel categoryModel)
        {
            try
            {
                categoryModel = bllcategory.DeleteCategory(id, categoryModel);
            }
            catch
            {
                // Handle any exceptions
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
