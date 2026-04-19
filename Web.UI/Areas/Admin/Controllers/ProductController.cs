using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        // 🏗️ DEPENDENCIES
        // - IProductServices (Product & Multi-Image CRUD)
        // - IPageService (CMS integration)
        // - IProductCategoriesService (Category selection logic)

        public ProductController(/* Injected Services */)
        {
            // Constructor logic
        }

        // =====================================================
        // 📦 1. MANAGE PRODUCTS (INDEX)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> ManageProduct()
        {
            // 🔍 Fetch all products via service layer

            // 💬 TempData Handling:
            // - Pass success messages (Product Added/Edited/Deleted) to ViewBag

            return View(/* Product List */);
        }

        // =====================================================
        // ➕ 2. CREATE PRODUCT (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            // 🏗️ ViewModel Initialization:
            // - Load CMS Page List for dropdown
            // - Load Product Categories for dropdown

            // 🎯 ViewBag:
            // - Store SelectList for CMS Pages

            return View(/* New ProductDetailViewModel */);
        }

        // =====================================================
        // 💾 3. CREATE PRODUCT (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(object model)
        {
            // 🛡️ Validation:
            // - Check ModelState. If invalid, reload dropdowns and return view.

            // 🏗️ Mapping & Logic:
            // 1. Map ViewModel → Product Entity
            // 2. Assign Slug, Audit Fields (CreatedDate, CreatedBy)
            // 3. Status: Set IsActive = true by default

            // 📁 Persistence:
            // 4. Call service: AddProductAsync (Handles main entity + Image uploads)

            // 💬 Success Message & Redirect
            return RedirectToAction("ManageProduct");
        }

        // =====================================================
        // ✏️ 4. EDIT PRODUCT (GET)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> EditProduct(int id)
        {
            // 🔍 Fetch:
            // - Get Product Details by ID (Return NotFound if null)

            // 🏗️ Data Preparation:
            // 1. Fetch CMS Pages dropdown
            // 2. Fetch Categories and map to ProductCategoryViewModel

            // 🎯 Return populated ViewModel to View
            return View(/* productDetails */);
        }

        // =====================================================
        // 💾 5. EDIT PRODUCT (POST)
        // =====================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(object model)
        {
            // 🛡️ Validation:
            // - If ModelState invalid: Reload Categories/Pages and return View

            // 🔍 Fetch Existing:
            // - Find current product from DB (integrity check)

            // 🧠 Update Logic:
            // 1. Map updated fields: Name, Slug, Short/Full Descriptions
            // 2. Update metadata: Application, Features, Downloads
            // 3. Set Audit Field: UpdatedDate = DateTime.Now

            // 💾 Service Call:
            // 4. UpdateProductAsync: Pass entity + AllImages, DefaultImage, PrimaryImage

            // 💬 Redirect to ManageProduct
            return RedirectToAction("ManageProduct");
        }

        // =====================================================
        // 🗑️ 6. DELETE PRODUCT
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            // 🛡️ Guard: Check ID (BadRequest if null)

            // ⚠️ Logic:
            // - Call service to remove product and its associated files/images
            // - Return NotFound if deletion fails

            // 💬 Success Message: "Product Deleted successfully!"
            return RedirectToAction(nameof(ManageProduct));
        }

        // =====================================================
        // 🖼️ 7. AJAX: DELETE PRODUCT IMAGE
        // =====================================================
        [HttpPost]
        public async Task<IActionResult> DeleteProductImage(int imageId)
        {
            // 🧩 Purpose: Single image removal from gallery via AJAX
            // 1. Call Service: DeleteProductImageAsync
            // 2. Return JSON success status

            return Json(new { success = true });
        }
    }
}