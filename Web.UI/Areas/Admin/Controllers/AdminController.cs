using BusinessObject.Interface;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        // =====================================================
        // 🏗️ DEPENDENCIES
        // =====================================================
        // - IBlogService: Business logic layer for blog operations (future use)
        // - CMSDbContext: Direct database access for admin operations
        private readonly IBlogService _blogService;
        private readonly CMSDbContext _context;

        public AdminController(IBlogService blogService, CMSDbContext context)
        {
            _blogService = blogService;
            _context = context;
        }

        // =====================================================
        // 📩 1. ENQUIRY LIST (ADMIN PANEL)
        // =====================================================
        [HttpGet]
        public async Task<IActionResult> EnquiryList()
        {
            // 🔍 Fetch all customer inquiries from database
            // - Data is retrieved from QuickInquiry table
            // - No filtering applied (all records shown)

            var inquiries = await _context.QuickInquiry
                .ToListAsync();

            // 📦 Pass data to view for rendering in admin panel
            return View(inquiries);
        }
    }
}