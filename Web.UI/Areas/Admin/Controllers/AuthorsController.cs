using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - Blog Service (Abstracted logic)
        // - DB Context (Data Access)

        public AuthorsController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 👥 1. AUTHORS LISTING (INDEX)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // 🔍 Fetch all authors/users ordered by latest ID

            // 🛡️ Success Message Handling:
            // - Check TempData for feedback (Create/Edit/Delete)
            // - Pass to ViewBag for Toastr/Alerts notification

            // 🎯 Return View with User List
            return View(/* User List */);
        }

        // =====================================================
        // ➕ 2. CREATE AUTHOR (GET)
        // =====================================================
        [HttpGet]
        public IActionResult Create()
        {
            // 🏗️ Initialize empty Author/User model
            return View();
        }

        // =====================================================
        // 💾 3. CREATE AUTHOR (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(object user)
        {
            // 🛡️ Validation:
            // 1. Check ModelState validity

            // 🔍 Duplicate Check:
            // 2. Ensure EmailAddress is unique in the database
            //    - If exists: Return ModelState Error

            // 🏗️ Logic:
            // 3. Set Audit Fields (CreatedAt = DateTime.Now)
            // 4. Save to Database

            // 💬 Feedback & Redirect:
            // 5. Store "Author added successfully!" in TempData

            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // ✏️ 4. EDIT AUTHOR (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            // 🛡️ Null Check:
            // - Return BadRequest if ID is null

            // 🔍 Fetch:
            // - Find User by ID
            // - Return NotFound if user doesn't exist

            // 🧠 Security/UI Note:
            // - Handle password display logic (masking or empty field)

            return View(/* User Model */);
        }

        // =====================================================
        // 💾 5. EDIT AUTHOR (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(object user)
        {
            // 🛡️ Validation:
            // 1. Ensure ModelState is valid

            // 🔍 Integrity Checks:
            // 2. Check if Email is taken by another User (ID exclusion)
            // 3. Fetch existing entity from DB (Tracking)

            // 🧠 Update Logic:
            // 4. Update basic fields (Names, Username, Status)
            // 5. Password Logic: Only update if a new password is provided
            // 6. Set Audit Fields (UpdatedAt = DateTime.Now)

            // 💾 Persistence:
            // 7. SaveChangesAsync inside Try-Catch block

            // 💬 Feedback:
            // 8. Store success message & Redirect

            return RedirectToAction(nameof(Index));
        }

        // =====================================================
        // 🗑️ 6. DELETE AUTHOR
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            // 🛡️ Validation:
            // - Check ID (BadRequest if null)
            // - Fetch record (NotFound if missing)

            // ⚠️ Logic:
            // - Remove user from context
            // - Persist changes

            // 💬 Feedback:
            // - TempData["SuccessMessage"] = "Deleted"

            return RedirectToAction(nameof(Index));
        }
    }
}