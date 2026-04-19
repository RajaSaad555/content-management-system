using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    // =====================================================
    // 🗺️ NAVIGATION MENU DOMAIN MODEL
    // =====================================================
    // [Table("Menu")] // Explicit table mapping if name differs from DbSet
    public class Menu
    {
        // 🆔 Primary Key: Unique identifier for the menu item
        [Key]
        public int Id { get; set; }

        // 🔗 Logical Mapping:
        // - ParentId: Self-referencing ID to create multi-level dropdowns
        // - PageId: Links the menu item directly to a CMS Page record
        public int? ParentId { get; set; }
        public int? PageId { get; set; }

        // 📝 Routing & Identity:
        // - Title: The display text shown in the navigation bar
        // - Url: The destination path (absolute or relative)
        // - Slug: SEO-friendly string for the link
        public string Title { get; set; }
        public string Url { get; set; }
        public string Slug { get; set; }

        // 🔢 Display Logic:
        // - Position: Numerical order to sort items from left-to-right or top-to-bottom
        // - IsActive: Toggle to show or hide the link without deleting it
        [Required]
        public int Position { get; set; }
        public bool? IsActive { get; set; }

        // 🕒 Audit & Lifecycle:
        // - CreatedAt / UpdatedAt: Standard tracking for record history
        // - DeletedAt: Soft-delete timestamp for recovery purposes
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // 👤 Administrative Ownership:
        // - CreatedBy: User ID or name of the initial creator
        // - UpdatedBy: User ID or name of the last person to modify the link
        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public string UpdatedBy { get; set; }
    }
}