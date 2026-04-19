using System;
using System.ComponentModel.DataAnnotations;

namespace Web.UI.Models
{
    // =====================================================
    // 🧱 GENERIC UTILITY MODEL
    // =====================================================
    public class GenericViewModel
    {
        // Placeholder for future shared properties across different views
    }

    // =====================================================
    // 📄 PAGE CONTENT DISPLAY MODEL
    // =====================================================
    public class PageContent
    {
        // 🆔 Identification: Unique key for the content record
        public int Id { get; set; }

        // 📝 Content Fields:
        // - PageName: The display title of the page
        // - Summary: A short excerpt or meta-description
        // - ContentBody: The primary HTML or text content for the page
        public string PageName { get; set; }
        public string summary { get; set; }
        public string ContentBody { get; set; }

        // 🕒 Audit: Timestamp of when the content was generated
        public DateTime CreatedAt { get; set; }
    }

    // =====================================================
    // 🔐 LOGIN AUTHENTICATION MODEL
    // =====================================================
    public class LoginViewModel
    {
        // 📧 Credentials:
        // - Email: Required, validated email address used as the username
        // - Password: Required, masked input field for security
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        // 🛠️ Session Management:
        // - RememberMe: Persists the authentication cookie across browser sessions
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}