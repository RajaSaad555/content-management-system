using BusinessObject.Interface;
using BusinessObject.ViewModel;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Application.Services;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        // =====================================================
        // 🏗️ DEPENDENCIES
        // =====================================================
        // - PageService: handles CMS/menu/business logic
        // - CMSDbContext: direct DB access (used for homepage data)
        private readonly IPageService _pageService;
        private readonly CMSDbContext _context;

        public HomeController(IPageService pageService, CMSDbContext context)
        {
            _pageService = pageService;
            _context = context;
        }

        // =====================================================
        // 🏠 1. HOME PAGE
        // =====================================================
        public IActionResult Index()
        {
            // 🔍 Fetch active sliders for homepage banner
            var sliders = _context.Slider
                .Where(s => s.IsActive == true)
                .OrderBy(s => s.SliderPosition)
                .ToList();

            // 🏷️ Fetch selected CMS brand pages
            var brands = _context.CMSPage
                .Where(p => p.Slug == "i-flex"
                         || p.Slug == "i-connect"
                         || p.Slug == "i-power")
                .OrderBy(p => p.Title)
                .Select(p => new CMSPageViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Slug = p.Slug,
                    Summary = string.IsNullOrEmpty(p.Summary)
                                ? p.ContentBody
                                : p.Summary,
                    ContentBody = p.ContentBody,
                    IsActive = p.IsActive == true
                })
                .ToList();

            // 📦 Pass data to View
            ViewBag.Brands = brands;
            ViewBag.ShowSlider = true;

            return View(sliders);
        }

        // =====================================================
        // 📩 2. PARTIAL VIEW - QUICK INQUIRY MODAL
        // =====================================================
        public IActionResult ModalPartial()
        {
            return PartialView("~/Views/Shared/_QuickInquiryForm.cshtml");
        }

        // =====================================================
        // 🔒 3. PRIVACY PAGE
        // =====================================================
        public IActionResult Privacy()
        {
            return View();
        }

        // =====================================================
        // ⚠️ 4. ERROR PAGE
        // =====================================================
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = HttpContext.TraceIdentifier
            });
        }

        // =====================================================
        // 📄 5. STATIC PAGES
        // =====================================================

        public IActionResult IFlex()
        {
            ViewBag.Message = "Your i-flex solutions page.";
            return View();
        }

        public IActionResult Events()
        {
            ViewBag.Message = "Events page.";
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Solutions()
        {
            ViewBag.Message = "Solutions page.";
            return View();
        }

        public IActionResult Career()
        {
            ViewBag.Message = "Career page.";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "About page.";
            return View();
        }

        public IActionResult RfCable()
        {
            ViewBag.Message = "RF Cable page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Contact page.";
            return View();
        }

        // =====================================================
        // 💬 6. REQUEST QUOTE PAGE
        // =====================================================
        public IActionResult RequestAQuote()
        {
            return View();
        }

        // =====================================================
        // 🚫 7. ERROR PAGE (CUSTOM SLUG ERROR)
        // =====================================================
        public IActionResult ErrorPage(string slug)
        {
            // 🔍 Capture invalid slug for display
            if (!string.IsNullOrEmpty(slug))
            {
                ViewBag.InvalidSlug = slug;
            }

            return View();
        }
    }
}