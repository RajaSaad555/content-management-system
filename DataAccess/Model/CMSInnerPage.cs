using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    // =====================================================
    // 📄 CMS INNER PAGE DOMAIN MODEL
    // =====================================================
    [Table("CMSInnerPage")]
    public class CMSInnerPage
    {
        // 🆔 Primary Key: Unique identifier for the inner page record
        [Key]
        public int Id { get; set; }

        // 🔗 Parent Association:
        // - PageId: Mandatory link to the primary CMS Page
        [Required]
        public int PageId { get; set; }

        // 📝 Core Content & Routing:
        // - Title: Main heading of the inner page
        // - Slug: SEO-friendly URL segment
        // - Summary: Brief excerpt for listings
        // - ContentBody: Main HTML/Text content of the page
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; }

        public string Summary { get; set; }
        public string ContentBody { get; set; }

        // 🛡️ Status & Visibility:
        // - IsActive: Binary toggle for public access
        [Required]
        public bool IsActive { get; set; }

        // 🕒 Audit & Lifecycle Timestamps:
        // - CreatedAt: Record creation time
        // - UpdatedAt: Last modification time
        // - DeletedAt: Soft-delete tracking timestamp
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // 👤 Administrative Tracking:
        // - CreatedBy: User ID/Username of the creator
        // - UpdatedBy: User ID/Username of the last modifier
        [Required]
        [MaxLength(100)]
        public string CreatedBy { get; set; }

        [Required]
        [MaxLength(100)]
        public string UpdatedBy { get; set; }

        // 🔍 SEO Metadata:
        // - MetaKeywords: Terms for search engine indexing
        // - MetaDescription: Summary snippet for search results
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
    }
}