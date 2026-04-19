using System;
using Microsoft.AspNetCore.Http;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 🛍️ PRODUCT CATEGORY VIEW MODEL
    // =====================================================
    public class ProductCategoryViewModel
    {
        // 🆔 Identification:
        // - CategoryID: Primary unique identifier for the category

        // 🔗 Selected Values (Foreign Keys/Links):
        // - CategoryName: The primary label for this category
        // - ParentCategoryID: Self-referencing link for hierarchical structure
        // - CMSPageID: Direct association with a specific CMS content page

        // 🏷️ Display Titles:
        // - ParentCategoryName: Readable name of the parent (for UI grids/lists)
        // - CMSPageTitle: Human-readable title of the linked CMS page

        // 📝 Metadata & Details:
        // - Description: Detailed summary of the category
        // - IsActive: Toggle for public visibility on the storefront

        // 🖼️ Media & File Handling:
        // - ImagePath: Relative path to the stored category image
        // - ImageName: Original or system-generated name of the image file
        // - File: IFormFile object for direct uploads via multipart forms

        // 🕒 Audit & Tracking:
        // - CreatedBy: ID of the administrative user who created the entry
        // - CreatedDate: Initial timestamp of creation
        // - UpdatedDate: Timestamp of the most recent modification
    }
}