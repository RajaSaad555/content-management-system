using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogCategoriesController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - IBlogService (Category operations)
        // - CMSDbContext (Direct DB access)

        public BlogCategoriesController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 📋 1. LIST & FORM WRAPPER (INDEX - GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // 🏗️ Initialize ViewModel:
            // - Fetch all categories for the listing table via Service Layer

            // 🎯 Return View with combined model (Form + List)
            return View(/* BlogCategoryCreateViewModel */);
        }

        // =====================================================
        // 💾 2. CREATE CATEGORY (INDEX - POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(object model)
        {
            // 🛡️ Validation:
            // 1. Check ModelState

            // 🧠 Logic:
            // 2. Map ViewModel to Domain Entity (BlogCategory)
            // 3. Apply Trimming on Name and Slug
            // 4. Persist via Service Layer (SaveCategoryAsync)

            // 💬 Feedback:
            // - Success: Set TempData and Redirect
            // - Failure: Reload categories for the table and return view

            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // ✏️ 3. EDIT CATEGORY (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            // 🛡️ Guards:
            // - BadRequest if id is null
            // - NotFound if category doesn't exist

            // 🏗️ Data Mapping:
            // - Map Entity (Name/Slug) back to ViewModel
            // - (Optional) Load all categories if the edit view shows a table

            return View(/* Populated ViewModel */);
        }

        // =====================================================
        // 💾 4. EDIT CATEGORY (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(object model)
        {
            // 🛡️ Validation:
            // 1. Check ModelState

            // 🔍 Fetch:
            // 2. Find existing category by ID

            // 🧠 Update Logic:
            // 3. Update Name and Slug with Trimmed values
            // 4. SaveChangesAsync

            // 💬 Redirect to Index with Success Message
            return RedirectToAction("Index");
        }

        // =====================================================
        // 🗑️ 5. DELETE CATEGORY
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            // 🛡️ Guards:
            // - ID null check
            // - Entity exists check

            // 🛑 Business Rule (Integrity Check):
            // - Eager load Related BlogPosts
            // - IF category has posts: Prevent deletion (Redirect)
            // - ELSE: Remove category and Save

            // 💬 Success Message in TempData
            return RedirectToAction(nameof(Index));
        }
    }
}