using BusinessObject.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class RenderMenuViewComponent : ViewComponent
{
    private readonly IPageService _pageService;

    public RenderMenuViewComponent(IPageService pageService)
    {
        _pageService = pageService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await _pageService.GetMenuHierarchyAsync();
        
        return View("MenuBar", menu);
    }

}