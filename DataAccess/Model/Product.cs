using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    // =====================================================
    // 📦 PRODUCT DOMAIN MODEL
    // =====================================================
    public class Product
    {
        // 🆔 Primary Key: Unique identifier for the product
        [Key]
        public int ProductID { get; set; }

        // 🏷️ Identity & SEO:
        // - ProductName: Required label for the item
        // - Slug: SEO-friendly URL segment for product routing
        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; }
        public string? Slug { get; set; }

        // 📝 Content & Specifications:
        // - ShortDescription: Brief snippet for catalog/grid views
        // - FullDetail: Comprehensive technical or marketing description
        // - Application: Specific use-cases or industries for the product
        // - Features: Key selling points or technical highlights
        // - Downloads: Links or paths to technical manuals/documentation
        [MaxLength(500)]
        public string ShortDescription { get; set; }
        public string FullDetail { get; set; }
        public string Application { get; set; }
        public string Features { get; set; }
        public string Downloads { get; set; }

        // 🖼️ Media:
        // - ImagePath: Relative path to the primary/thumbnail image
        [MaxLength(300)]
        public string? ImagePath { get; set; }

        // 🛡️ Status & Audit:
        // - IsActive: Visibility toggle for the public storefront
        // - CreatedBy: Administrative user who added the product
        // - CreatedDate / UpdatedDate: Lifecycle tracking timestamps
        public bool IsActive { get; set; } = true;
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        // =====================================================
        // 🔗 RELATIONSHIPS & NAVIGATION
        // =====================================================

        // 📂 Category Mapping:
        // - CategoryID: Required foreign key to the product taxonomy
        // - Category: Navigation property for relational access
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        // 📄 CMS Integration:
        // - InnerPageID: Optional link to a specific CMS Inner Page for custom content
        // - InnerPage: Navigation property to access page details
        public int? InnerPageID { get; set; }

        [ForeignKey("InnerPageID")]
        public virtual CMSInnerPage? InnerPage { get; set; }

        // 🖼️ Gallery:
        // - ProductImages: Collection of secondary images for the product carousel
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    }
}