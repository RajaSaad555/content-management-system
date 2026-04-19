using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoriesController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - IProductCategoriesService (Business Logic)
        // - IPageService (CMS Page integration)
        // - IWebHostEnvironment (Physical file path handling)

        public ProductCategoriesController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 📋 1. LIST CATEGORIES (INDEX)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // 🔍 Fetch full category list (including hierarchy if applicable)

            // 💬 Feedback:
            // - Retrieve and pass SuccessMessage from TempData to ViewBag

            return View(/* Categories List */);
        }

        // =====================================================
        // ➕ 2. CREATE CATEGORY (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            // 🏗️ Form Preparation:
            // 1. Load Parent Categories for dropdown (Hierarchy)
            // 2. Load CMS Pages (Link category to a static page)
            // 3. Load Category Names (Pre-defined list if applicable)

            return View();
        }

        // =====================================================
        // 💾 3. CREATE CATEGORY (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(object model, IFormFile? file)
        {
            // 🛡️ Data Sanitization:
            // - If ParentCategoryID is 0, set to NULL (Top-level category)

            // ✅ Validation:
            // 1. Check ModelState

            // 📁 File Handling:
            // 2. Call Helper: UploadCategoryImageAsync (saves file, returns path/name)

            // 🧠 Mapping & Persistence:
            // 3. Map model to Category Entity
            // 4. Set Audit Fields (CreatedDate, CreatedBy)
            // 5. Save via Service Layer

            // 💬 Success & Redirect
            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // ✏️ 4. EDIT CATEGORY (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // 🔍 Fetch:
            // - Get Category by ID (Return NotFound if null)

            // 🏗️ Data Preparation:
            // 1. Load Parent Categories dropdown
            // 2. Load Category Names List
            // 3. Load CMS Pages & Pre-select the linked page

            return View(/* Category Entity */);
        }

        // =====================================================
        // 💾 5. EDIT CATEGORY (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(object category, IFormFile? file, bool removeImage = false)
        {
            // 🛡️ Pre-checks:
            // - Set ParentCategoryID to NULL if 0

            // 🔍 Fetch Existing:
            // - Get record from DB to maintain data integrity

            // 📁 Image Logic Scenarios:
            // Scenario A: New file uploaded -> Delete old, save new.
            // Scenario B: 'removeImage' is true -> Delete old from disk, clear DB fields.
            // Scenario C: No change -> Retain existing paths.

            // 🧠 Update & Save:
            // - Sync fields (CMSPageID, Name, ParentID, etc.)
            // - Persist changes via Service Layer

            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // 🗑️ 6. DELETE CATEGORY
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            // 🛡️ Guard: Ensure ID exists

            // 🛑 Business Logic Check:
            // - Call Service: Ensure category has NO child categories before deleting

            // 💬 Feedback:
            // - Set ErrorMessage or SuccessMessage in TempData based on result

            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // 🛠️ HELPER: IMAGE UPLOAD & CLEANUP
        // =====================================================
        private async Task<(string imagePath, string imageName)> UploadCategoryImageAsync(IFormFile file, string oldImagePath = null)
        {
            // 1. Guard: If no file, return old path/name
            // 2. Path Setup: Point to "wwwroot/Uploads/categories"
            // 3. Cleanup: If 'oldImagePath' exists, delete physical file from server
            // 4. Save: Generate GUID name, save stream to disk
            // 5. Return: New relative path and original file name

            return (/* path */, /* name */);
        }
    }
}