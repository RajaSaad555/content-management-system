using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    // Note: Area is not explicitly defined in the class attribute in your source, 
    // but the namespace suggests it belongs to Admin.
    [Area("Admin")]
    public class QuickInquiryController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - IBlogService (Abstracted logic)
        // - CMSDbContext (Direct DB access for quick logging)

        public QuickInquiryController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 🧩 1. LOAD PARTIAL VIEW
        // =====================================================
        [HttpGet]
        public IActionResult QuickInquiryPartial()
        {
            // 🎯 Purpose: Returns the reusable form component
            // - Points to: ~/Views/Shared/_QuickInquiryForm.cshtml

            return PartialView("_QuickInquiryForm");
        }

        // =====================================================
        // 📥 2. SUBMIT INQUIRY (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(object model)
        {
            // 🛡️ Validation:
            // 1. Check ModelState
            // - If invalid: Set ErrorMessage in TempData and redirect back to Home/Contact

            // 🏗️ Logic:
            // 2. Wrap in Try-Catch for database safety
            // 3. Set Audit Fields: model.CreatedDate = DateTime.Now
            // 4. Add to Context and SaveChangesAsync

            // 💬 Feedback:
            // - Success: Set "Your inquiry has been submitted successfully!"
            // - Exception: Log error and set generic failure message

            // 🔁 Redirect:
            // - Always redirects back to the Contact page of the Home controller
            return RedirectToAction("Contact", "Home");
        }
    }
}