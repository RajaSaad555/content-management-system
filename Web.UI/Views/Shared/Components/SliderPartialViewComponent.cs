using BusinessObject.Interface;
using Microsoft.AspNetCore.Mvc;
namespace Web.UI.Views.Shared.Components
{
    public class SliderPartialViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public SliderPartialViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliderlist = await _sliderService.GetSliderListAsync();

            return View("SliderPartial", sliderlist);
        }
    }
}
