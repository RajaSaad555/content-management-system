using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    // =====================================================
    // 📂 BLOG CATEGORY DOMAIN MODEL
    // =====================================================
    public class BlogCategory
    {
        // 🆔 Primary Key: Unique identifier for the category
        [Key]
        public int Id { get; set; }

        // 🏷️ Identity:
        // - Name: Display name of the category (e.g., "Technology")
        // - Slug: SEO-friendly URL segment (e.g., "technology-updates")
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; }

        // 🛡️ Status & Lifecycle:
        // - IsActive: Flag to enable/disable category visibility
        // - CreatedAt: Timestamp of initial record creation
        // - UpdatedAt: Timestamp of the most recent modification
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // 🔗 Relationships:
        // - BlogPosts: One-to-Many collection linking all posts under this category
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}