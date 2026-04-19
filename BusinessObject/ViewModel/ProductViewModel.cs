using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 📦 1. PRODUCT LISTING MODEL
    // =====================================================
    public class ProductViewModel
    {
        // 🆔 Identification:
        // - ProductID: Unique key
        // - CategoryID: Required link to the product taxonomy

        // 📝 Basic Info:
        // - ProductName: Core display label
        // - ShortDescription: Brief snippet for listing pages
        // - Slug: URL-friendly identifier for routing

        // 🛠️ Specifications:
        // - FullDetail, Application, Features, and Downloads (Files/Links)

        // 🕒 Audit & State:
        // - Created/Updated timestamps and User tracking
        // - IsActive: Catalog visibility toggle

        // 🔗 Flattened Data:
        // - CategoryName: Joined string for quick UI display without extra lookups
    }

    // =====================================================
    // 🔍 2. PRODUCT DETAIL & MANAGEMENT MODEL
    // =====================================================
    public class ProductDetailViewModel
    {
        // 🔗 Relationships:
        // - CMSPageID: Associated content page
        // - CategoryID: Target category for the product

        // 📄 Content:
        // - FullDescription & Application: Rich text required for product pages
        // - Features & Downloads: Technical specs and documentation links

        // 🖼️ Media Management:
        // - AllImages: Collection of IFormFile for batch uploads
        // - ImagesList: Existing ProductImage entities from the DB
        // - PrimaryImage: ID pointer for the main "Hero" image
        // - DefaultImage: Single file upload for the primary thumbnail

        // 📑 Contextual Lists:
        // - ListOfPages: Available CMS pages for selection
        // - ListOfCategories: Available Product categories for dropdowns
    }

    // =====================================================
    // 📍 3. NAVIGATION UTILITY
    // =====================================================
    public class BreadcrumbItem
    {
        // 🏗️ Structure:
        // - Title: Human-readable link text (e.g., "Home")
        // - Url: Destination path for the breadcrumb step
        // - IsActive: Flag to identify the current page in the trail
    }
}