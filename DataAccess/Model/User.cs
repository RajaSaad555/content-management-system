using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    // =====================================================
    // 👤 USER ACCOUNT DOMAIN MODEL
    // =====================================================
    public class User
    {
        // 🆔 Primary Key: Unique identifier for the system user
        [Key]
        [Required]
        public int Id { get; set; }

        // 📝 Identity:
        // - FirstName / LastName: Legal or display name components
        // - Username: Unique handle for login identification
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Username { get; set; }

        // 🔐 Security:
        // - Password: Required string with strict complexity requirements:
        //   * Minimum 8 characters
        //   * Must include: Uppercase, Lowercase, Number, and Special Character (@$!%*?&)
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include an uppercase letter, lowercase letter, number, and special character.")]
        public string Password { get; set; }

        // 📧 Communication & Verification:
        // - EmailAddress: Required validated email format
        // - EmailVerified: Boolean flag for security/onboarding status
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public bool? EmailVerified { get; set; }

        // 🛡️ Status & Audit:
        // - IsActive: Toggle for account access (e.g., suspension or deactivation)
        // - CreatedAt / UpdatedAt: Standard account lifecycle timestamps
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}