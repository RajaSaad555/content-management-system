using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.ViewModel;
using DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Interface
{
    public interface IProductServices
    {

        Task<List<ProductViewModel>> GetProductsByInnerPageSlugAsync(string slug);

        Task<List<ProductViewModel>> GetProductListAsync();

        Task<ProductDetailViewModel> GetProductDetailByIDAsync(int productId);


        Task<Product?> GetProductByIdAsync(int id);


        //Task AddProductAsync(Product product, List<string> images, string defaultImage);



        //Task AddProductAsync(Product product, List<IFormFile> images, IFormFile defaultImage);


        //Task AddProductAsync(Product product, List<IFormFile> images, IFormFile defaultImage);
        Task AddProductAsync(Product product, List<IFormFile>? images, IFormFile? defaultImage, int? primaryImageId = null);



        //  Task UpdateProductAsync(Product product, List<IFormFile>? images, IFormFile? defaultImage, int? primaryImageId = null);
        Task UpdateProductAsync(Product product, List<IFormFile>? images, IFormFile? defaultImage, int? primaryImageId = null);
        Task<bool> DeleteProductAsync(int productId);
        Task<bool> DeleteProductImageAsync(int imageId);


    }
}
