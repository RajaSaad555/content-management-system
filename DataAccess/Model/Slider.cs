using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    // =====================================================
    // 🎞️ HOMEPAGE SLIDER DOMAIN MODEL
    // =====================================================
    public class Slider
    {
        // 🆔 Primary Key: Unique identifier for the slider entry
        [Key]
        [Required]
        public int SliderId { get; set; }

        // 🖼️ Media & Routing:
        // - SliderImageUrl: Path to the banner/background image
        // - SliderLink: Destination URL when the slide or button is clicked
        public string? SliderImageUrl { get; set; }
        public string? SliderLink { get; set; }

        // 🔢 Display Logic:
        // - SliderPosition: Numerical order for sequencing (1st, 2nd, etc.)
        // - IsActive: Visibility toggle for the public homepage
        public int? SliderPosition { get; set; }
        public bool? IsActive { get; set; }

        // 📝 Content Overlay:
        // - SliderHeadingText: Primary title shown over the image
        // - SliderDescriptionText: Subtitle or supporting body text
        public string? SliderHeadingText { get; set; }
        public string? SliderDescriptionText { get; set; }

        // 🕒 Lifecycle & Audit:
        // - CreatedAt / UpdatedAt: Record history timestamps
        // - DeletedAt: Soft-delete tracking
        // - CreatedBy / UpdatedBy: User tracking for administrative accountability
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}