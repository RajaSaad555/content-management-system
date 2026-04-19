using System;

namespace BusinessObject.ViewModel
{
    // =====================================================
    // 📄 CMS INNER PAGE MODEL
    // =====================================================
    public class CMSInnerPageViewModel
    {
        // 🆔 Identification:
        // - Id: Primary key for the inner page
        // - PageId: Foreign key linking to the parent CMS Page

        // 📝 Content Details:
        // - Title: Heading of the inner page
        // - Slug: URL-friendly identifier
        // - Summary: Brief overview or excerpt
        // - ContentBody: Full HTML or text content

        // 🛡️ Status & Audit:
        // - IsActive: Visibility toggle
        // - CreatedAt / UpdatedAt: Lifecycle timestamps

        // 🔍 SEO Metadata:
        // - MetaKeywords: Targeted search terms
        // - MetaDescription: Snippet for search engine results
    }
}