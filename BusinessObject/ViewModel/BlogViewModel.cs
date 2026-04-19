using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 📝 1. BLOG POST MODELS
    // =====================================================
    public class BlogPostDisplay
    {
        // 🆔 Unique Identifier
        // 🏷️ Title & Category Name (Flattened for display)
        // 📄 Content Body Preview
        // 📅 Audit: Creation Timestamp
    }

    public class PostViewModel
    {
        // 🏗️ Core Entity: BlogPost (Main content)
        // 📑 Lookups: List of available BlogCategories
        // 👤 User Context: ID of the author/creator
        // 🔗 Relationships: List of SelectedCategory IDs for multi-select
    }

    // =====================================================
    // 📂 2. BLOG CATEGORY MODELS (MANAGEMENT)
    // =====================================================
    public class BlogCategoryCreateViewModel
    {
        // 🏗️ Initialization:
        // - Required: Title & Slug (SEO friendly URL)
        // - Collection: List of existing categories for reference
    }

    public class BlogCategoryViewModel
    {
        // 🛠️ Data Structure:
        // - Identity: Id, Name, and Slug
        // - State: IsActive toggle
        // - Audit: CreatedAt / UpdatedAt timestamps
        // 🌲 Hierarchy: Nested BlogCategories and linked BlogPosts
    }

    public class CategoryPageViewModel
    {
        // 🧩 Composite: 
        // - Single "NewCategory" object for creation forms
        // - Full "Categories" list for dashboard tables
    }

    // =====================================================
    // 📖 3. BLOG CONTENT VIEW MODELS
    // =====================================================
    public class BlogViewModel
    {
        // 🖼️ Media: ImagePath and ImageName for banner/thumbnail
        // 🛡️ Validation:
        // - Title (Length: 1-100)
        // - Slug (Length: 1-150)
        // 📄 Body: Full HTML/Text content body
        // 🌳 Relationships: Linked BlogCategories & Child SubCategories
    }

    // =====================================================
    // 🏷️ 4. CATEGORY UTILITY MODELS (MODES)
    // =====================================================
    public class AddCategoryViewModel
    {
        // ➕ Simplified Create: Basic validation for Title and Slug only
    }

    public class EditCategoryViewModel
    {
        // ✏️ Focused Edit: 
        // - Holds target Category entity
        // - Holds collection of all Categories for parent selection
    }

    // =====================================================
    // 🛍️ 5. PRODUCT CATEGORY MODELS (E-COMMERCE)
    // =====================================================
    public class ProductCategoryDisplay
    {
        // 📊 Projection:
        // - Category Details (ID, Name, Description)
        // - Parent Mapping: Displays Parent Name instead of ID for readability
        // - Status: Visibility/Active state
    }
}