using BusinessObject.ViewModel;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Interface
{
    public interface ISliderService
    {
        Task<List<Slider>> GetSliderListAsync();
        Task<Slider?> GetSliderByIdAsync(int id);
        Task<Slider> SaveSliderAsync(Slider slider);   // Create
        Task<Slider> UpdateSliderAsync(Slider slider); // Edit
        Task<bool> DeleteSliderAsync(int id);
    }
}



