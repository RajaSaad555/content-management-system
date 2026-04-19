using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.ViewModel;
using DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Interface
{
    public interface IProductCategoriesService
    {
        Task<List<ProductCategoryViewModel>> GetProductCategoryListAsync();
          Task<List<Category>> GetCategoryList();
        Task<Category> GetProductCategoryByIDAsync(int id);
        Task<Category> SaveProductCategoryAsync(Category category);
        Task<Category> UpdateProductCategoryAsync(Category Category);


        Task<bool> DeleteProductCategoryAsync(int id);
        Task<List<SelectListItem>> GetCategoryNamesListAsync();
        Task<List<SelectListItem>> GetCmsPageSelectListAsync(int? selectedId = null);




    }
}
