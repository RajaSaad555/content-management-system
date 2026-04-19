using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    // =====================================================
    // 📩 QUICK INQUIRY DOMAIN MODEL
    // =====================================================
    public class QuickInquiry
    {
        // 🆔 Primary Key: Unique identifier for the inquiry record
        [Key]
        public int ID { get; set; }

        // 👤 Lead Identity:
        // - Name: Full name of the interested party
        // - Email: Validated email address for primary communication
        // - Phone: Optional contact number
        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        // 🏢 Corporate Information:
        // - Company: General company details or department
        // - CompanyName: Official organization name (Required)
        public string? Company { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        // 📍 Market & Context:
        // - TerritorySlot: Geographic region or business territory
        // - Enquirytype: Categorization of the lead (e.g., Sales, Support, Partnership)
        public string? TerritorySlot { get; set; }

        public string? Enquirytype { get; set; }

        // 💬 Message Content:
        // - Message: The core text or specific requirements of the inquiry
        [Required]
        public string? Message { get; set; }

        // 🕒 Audit & Tracking:
        // - CreatedDate: Timestamp of when the inquiry was submitted
        public DateTime? CreatedDate { get; set; }
    }
}