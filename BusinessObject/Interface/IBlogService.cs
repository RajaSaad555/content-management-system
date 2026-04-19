using BusinessObject.ViewModel;
using DataAccess.Model;

namespace BusinessObject.Interface
{
    public interface IBlogService
    {
        // =====================================================
        // 📄 1. GET POSTS LIST
        // =====================================================
        Task<List<BlogPostDisplay>> GetPostListAsync(int userId);

        // =====================================================
        // 📚 2. GET ALL CATEGORIES
        // =====================================================
        Task<List<BlogCategory>> GetAllCategoriesAsync();

        // =====================================================
        // 💾 3. CREATE NEW BLOG POST
        // =====================================================
        Task SavePostDataAsync(PostViewModel model);

        // =====================================================
        // ✏️ 4. GET POST FOR EDIT
        // =====================================================
        Task<PostViewModel> GetEditPostAsync(int id);

        // =====================================================
        // 💾 5. UPDATE EXISTING POST
        // =====================================================
        Task EditPostData(PostViewModel model);

        // =====================================================
        // 📂 6. SAVE CATEGORY
        // =====================================================
        Task SaveCategoryAsync(BlogCategory category);
    }
}