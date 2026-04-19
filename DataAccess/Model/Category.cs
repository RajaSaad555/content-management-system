using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DataAccess.Model
{
    // =====================================================
    // 📂 PRODUCT CATEGORY DOMAIN MODEL
    // =====================================================
    public class Category
    {
        // 🆔 Primary Key: Unique identifier for the product category
        [Key]
        public int CategoryID { get; set; }

        // 🔗 CMS Integration:
        // - CMSPageID: Foreign key linking to a related CMS content page
        // - CMSPage: Virtual navigation property for content association
        public int? CMSPageID { get; set; }

        [ValidateNever]
        public virtual CMSPage CMSPage { get; set; }

        // 🏷️ Identity & SEO:
        // - CategoryName: The official name of the category
        // - Slug: SEO-friendly URL segment
        // - Description: Detailed summary of the category's purpose
        [Required]
        [MaxLength(200)]
        public string CategoryName { get; set; }

        [Required]
        public string Description { get; set; }

        public string? Slug { get; set; }

        // 🖼️ Media & File Handling:
        // - ImagePath: Database path to the stored image
        // - ImageName: Display name or original filename of the image
        // - ImageFile: Physical file object for uploads (Excluded from Database Schema)
        public string? ImagePath { get; set; }
        public string? ImageName { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        // 🛡️ Status & Audit:
        // - IsActive: Toggle for category visibility (Defaults to true)
        // - CreatedBy: ID of the administrative user
        // - CreatedDate / UpdatedDate: Lifecycle tracking timestamps
        public bool IsActive { get; set; } = true;
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ValidateNever]
        public DateTime? UpdatedDate { get; set; }

        // =====================================================
        // 🌲 HIERARCHICAL & RELATIONAL NAVIGATION
        // =====================================================

        // 🔗 Parent-Child Linking:
        // - ParentCategoryID: Self-referencing foreign key for nested trees
        // - ParentCategory: Navigation to the root/parent level
        public int? ParentCategoryID { get; set; }

        [ForeignKey("ParentCategoryID")]
        [ValidateNever]
        public virtual Category ParentCategory { get; set; }

        // 🌿 Collections:
        // - SubCategories: Recursive list of child categories
        // - Products: List of items assigned specifically to this category
        public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}