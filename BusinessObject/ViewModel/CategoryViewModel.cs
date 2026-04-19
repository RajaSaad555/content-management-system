using System;
using System.Collections.Generic;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 🛍️ PRODUCT CATEGORY & HIERARCHY MODEL
    // =====================================================
    public class CategoryViewModel
    {
        // 🆔 Unique Identifier: Category Primary Key
        // 🏷️ Identity: Title, Category Name, and SEO-friendly Slug

        // 🔗 Relationships (Associations):
        // - CMSPageId: Linked content page identifier
        // - ParentCategoryID: Self-referencing link for parent-child tree

        // 🖼️ Media: File path for category banner or thumbnail image

        // 🌳 Hierarchical Structure:
        // - SubCategories: Nested list for recursive tree building
        // - Products: Collection of items belonging to this category

        // 📄 Linked Metadata:
        // - PageData: Detailed CMS page entity (SEO, Content, Layout)
        // - CategoryData: Self-referencing detail object
    }
}