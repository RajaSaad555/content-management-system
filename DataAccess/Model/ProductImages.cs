using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    // =====================================================
    // 🖼️ PRODUCT IMAGE DOMAIN MODEL
    // =====================================================
    public class ProductImage
    {
        // 🆔 Primary Key: Unique identifier for the specific image record
        [Key]
        public int ImageID { get; set; }

        // 🔗 Parent Association:
        // - ProductID: Foreign key linking this image to a specific Product
        [Required]
        public int ProductID { get; set; }

        // 📝 Identity & Pathing:
        // - ImageName: Descriptive name or original filename
        // - ImageUrl: Fully qualified or relative path to the image file
        public string ImageName { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string ImageUrl { get; set; } = string.Empty;

        // 🛡️ Logic & State:
        // - IsPrimary: Flag to identify the main "Hero" image for product listings
        // - CreatedDate: Timestamp of when the image was uploaded/linked
        public bool IsPrimary { get; set; }

        public DateTime CreatedDate { get; set; }

        // =====================================================
        // 🌲 NAVIGATION
        // =====================================================

        // 🏗️ Relationship Mapping:
        // - Product: Navigation property for Entity Framework relational mapping
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}