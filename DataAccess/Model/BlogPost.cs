using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DataAccess.Model
{
    // =====================================================
    // 📝 BLOG POST DOMAIN MODEL
    // =====================================================
    [Table("BlogPost")]
    public class BlogPost
    {
        // 🆔 Primary Key: Unique identifier for the blog entry
        [Key]
        public int Id { get; set; }

        // 📄 Core Content:
        // - Title: The main heading of the post
        // - Slug: SEO-friendly URL segment
        // - ContentBody: The full article text or HTML content
        // - Summary: A brief excerpt or intro for listing pages
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ContentBody { get; set; }
        public string? Summary { get; set; }

        // 🔍 Search Engine Optimization (SEO):
        // - MetaTitle: Specific title for search engine results
        // - MetaKeyword: Targeted keywords for indexing
        // - MetaKeywordDescription: Meta description for search snippets
        public string? MetaTitle { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaKeywordDescription { get; set; }

        // 🌐 Social Media (Open Graph):
        // - OgImagePath: Path to the image displayed when shared on social platforms
        // - OgImageAlt: Alternative text for social media accessibility
        [ValidateNever]
        public string? OgImagePath { get; set; }
        [ValidateNever]
        public string? OgImageAlt { get; set; }

        // 🕒 Audit & Workflow:
        // - Status: Current state (e.g., Draft, Published, Archived)
        // - CreatedBy: ID of the user who authored the post
        // - CreatedAt / UpdatedAt: Lifecycle tracking timestamps
        // - PublishedAt: The specific date/time the post went live
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        [ValidateNever]
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }

        // 🔗 Relationships:
        // - BlogCategoryId: Foreign key linking to the parent category
        // - BlogCategory: Navigation property for EF Core relational mapping
        [ForeignKey("BlogCategoryId")]
        public int? BlogCategoryId { get; set; }

        [ValidateNever]
        public BlogCategory BlogCategory { get; set; }
    }
}