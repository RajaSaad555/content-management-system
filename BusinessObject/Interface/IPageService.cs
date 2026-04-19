namespace SampleProject.Application.Interfaces
{
    public interface IContentService
    {
        // =====================================================
        // 📄 CONTENT RETRIEVAL
        // =====================================================
        Task<object> GetContentBySlugAsync(string slug);
        Task<object> GetContentByIdAsync(int id);
        Task<object> GetChildContentAsync(int parentId);

        // =====================================================
        // 📋 LISTING
        // =====================================================
        Task<object> GetContentListAsync();
        Task<object> GetContentWithRelationsAsync();

        // =====================================================
        // 🌲 HIERARCHY / NAVIGATION
        // =====================================================
        Task<object> GetNavigationHierarchyAsync();
        Task<object> GetActiveNavigationAsync();

        // =====================================================
        // 🛍️ CATEGORY / PRODUCT STRUCTURE
        // =====================================================
        Task<object> GetCategoryTreeAsync(int categoryId);

        // =====================================================
        // 📊 DASHBOARD / ANALYTICS
        // =====================================================
        Task<object> GetDashboardStatsAsync(int userId);

        // =====================================================
        // 📝 CONTENT CREATION
        // =====================================================
        Task<object> SaveContentAsync(object model);

        // =====================================================
        // 🗑️ DELETE
        // =====================================================
        Task<bool> DeleteContentAsync(int id);

        // =====================================================
        // 📰 BLOG / ARTICLE
        // =====================================================
        Task<object> GetArticleByIdAsync(int id);
    }
}