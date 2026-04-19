using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 🖼️ 1. SLIDER & MEDIA MODELS
    // =====================================================
    public class SliderViewModel
    {
        // 🏷️ Display Content: Heading, Description, and Image Source URL
    }

    // =====================================================
    // 📄 2. CMS PAGE & CONTENT MANAGEMENT
    // =====================================================
    public class CMSPageViewModel
    {
        // 🆔 Identity: Page ID and Parent/Child linking
        // 📝 Content: Title, Body, Summary, and URL Slug
        // 🔍 SEO: Keywords and Meta Description tracking
        // 📑 UI: Dropdown items for parent menu selection
        // 🛡️ Status: IsActive toggle and Lifecycle Timestamps (Created/Updated/Deleted)
    }

    public class ContentViewModel
    {
        // 🏗️ Core Entity: Combines BlogPosts, Categories, and Sliders
        // 🖼️ Media Handling: Support for IFormFile (SliderImageFile) and OG Meta Images
        // 🔍 SEO & Meta: Detailed Keywords, Alt tags, and Social Media titles
        // 👤 Context: UserID tracking for content authorship
    }

    // =====================================================
    // 🌲 3. NAVIGATION & HIERARCHY MODELS
    // =====================================================
    public class MenuItemViewModel
    {
        // 🌿 Navigation Node: Represents a menu link with its parent/child relationships
        // 🔗 Content Nesting: Contains child pages and associated product categories
        // ⚙️ Visibility: Flags for Active status and Top-Menu placement
    }

    public class CategoryNameViewModel
    {
        // 📂 Product Taxonomy:
        // - Self-referencing list for nested SubCategories
        // - Direct link to associated Products
        // - Connection to parent CMS Page for context
    }

    // =====================================================
    // 🍱 4. COMPOSITE DISPLAY MODELS (AGGREGATORS)
    // =====================================================
    public class PageViewModel
    {
        // 🧩 Multi-Content: Holds the main Page, Inner Pages, Blogs, and Sliders
        // 🛍️ E-Commerce: Includes the full Category hierarchy for sidebars/menus
    }

    public class MenuViewModel
    {
        // 🗺️ Layout: Maps a specific CMS Page to its related Category tree
    }

    // =====================================================
    // 🛒 5. E-COMMERCE MENU SPECIFICS
    // =====================================================
    public class CategoryMenuViewModel
    {
        // 🌲 Nested Structure: Deep-linked SubCategories and Products for Mega-Menus
        // 🖼️ Visuals: Icon/Image paths for category identification
    }

    public class ProductMenuViewModel
    {
        // 📦 Lightweight Product: Basic info (Name, Slug, Image) for menu previews
    }
}