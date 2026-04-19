using BusinessObject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - ISliderService (Business logic for slider CRUD)
        // - IWebHostEnvironment (File system access for images)

        public SliderController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 🎞️ 1. SLIDER LISTING (INDEX)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // 🔍 Fetch all sliders via service
            // 🛡️ Error Handling: Return NotFound if result is null

            // 💬 UI Feedback:
            // - Pass SuccessMessage from TempData to ViewBag (for alerts)

            return View(/* Slider List */);
        }

        // =====================================================
        // ➕ 2. CREATE SLIDER (GET)
        // =====================================================
        [HttpGet]
        public IActionResult Create()
        {
            // 🏗️ Initialize: Pass new ContentViewModel with a blank Slider object
            return View(new ContentViewModel());
        }

        // =====================================================
        // 💾 3. CREATE SLIDER (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(object model, IFormFile? file)
        {
            // 🛡️ Manual Validation:
            // 1. Force check if 'file' is null (Images are mandatory for new sliders)

            // 🔍 Debugging Logic (Advanced):
            // 2. Loop through ModelState to catch and log hidden validation errors

            // 📁 File Processing:
            // 3. Define path: "wwwroot/uploads/sliders"
            // 4. Generate unique filename (Timestamp + Original Name)
            // 5. Save stream to physical directory

            // 🧠 Mapping:
            // 6. Set SliderImageUrl, CreatedAt, and CreatedBy (Session based)
            // 7. Persist via Service Layer

            // 💬 Redirect to Index with Success Message
            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // ✏️ 4. EDIT SLIDER (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // 🔍 Fetch existing slider by ID
            // 🏗️ Map into ContentViewModel for the Edit view

            return View(/* ViewModel */);
        }

        // =====================================================
        // 💾 5. EDIT SLIDER (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(object vm)
        {
            // ✅ Validation Check:
            // 1. Ensure Model is valid

            // 🔍 Sync with DB:
            // 2. Fetch existing slider record (Tracking)
            // 3. Update fields: Heading, Description, Link, Position
            // 4. Update Audit fields: UpdatedBy, UpdatedAt

            // 📁 Conditional Image Update:
            // 5. IF new image uploaded: 
            //    - Save new file to disk
            //    - Update SliderImageUrl
            // 6. ELSE: Keep existing image path

            // 💾 Persist via UpdateSliderAsync
            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // 🗑️ 6. DELETE SLIDER
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            // 🔍 Fetch and show confirmation view
            return View(/* Slider Entity */);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // ⚠️ Action:
            // 1. Remove from database
            // 💬 Success Message: "Slider Deleted successfully"

            return RedirectToAction(nameof(Index));
        }
    }
}