using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    // =====================================================
    // 📄 CMS MAIN PAGE DOMAIN MODEL
    // =====================================================
    public class CMSPage
    {
        // 🆔 Primary Key: Unique identifier for the main CMS page
        [Key]
        public int Id { get; set; }

        // 🏷️ Identity & Content:
        // - Title: Required display name for the page
        // - Slug: URL-friendly identifier for routing
        // - Summary: Brief excerpt for previews or SEO snippets
        // - ContentBody: Primary HTML/text content for the page
        [Required]
        public string Title { get; set; }
        public string? Slug { get; set; }
        public string? Summary { get; set; }
        public string? ContentBody { get; set; }

        // 🛡️ Status & Configuration:
        // - IsActive: Visibility toggle for public access
        // - IsInnerPage: Flag to distinguish between root and child pages
        // - IntopMenu: Flag to determine if the page appears in the primary navigation
        public bool? IsActive { get; set; }
        public bool? IsInnerPage { get; set; }
        public bool? IntopMenu { get; set; }

        // 🕒 Audit & Lifecycle:
        // - CreatedAt / UpdatedAt: Standard tracking timestamps
        // - DeletedAt: Soft-delete tracking for data recovery
        // - CreatedBy / UpdatedBy: User tracking for administrative accountability
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // 🔍 SEO Metadata:
        // - MetaKeywords: Targeted keywords for indexing
        // - MetaDescription: Summary snippet for search results
        public string? MetaKeywords { get; set; }
        public string? MetaDescription { get; set; }

        // =====================================================
        // 🌲 HIERARCHICAL NAVIGATION
        // =====================================================

        // 🔗 Parent-Child Mapping:
        // - ParentId: Self-referencing foreign key for menu nesting
        // - Parent: Navigation property for Entity Framework relational mapping
        public int? ParentId { get; set; }
        public CMSPage Parent { get; set; }
    }
}