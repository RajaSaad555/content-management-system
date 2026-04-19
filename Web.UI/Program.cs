using BusinessObject.Interface;
using BusinessObject.Service;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Register your service
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IPageService, PageService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IProductCategoriesService, ProductCategoriesService>();
builder.Services.AddScoped<IProductServices, ProductServices>();





// ✅ Add EF Core DbContext
builder.Services.AddDbContext<CMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add session services
builder.Services.AddDistributedMemoryCache(); // stores session in memory
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});




var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession(); 
app.UseAuthorization();

// 1️⃣ Areas (always first)
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


// 2️⃣ Product Detail (most specific)
app.MapControllerRoute(
    name: "ProductDetail",
    pattern: "product-detail/{slug}-{id:int}",
    defaults: new { controller = "Page", action = "ViewProductDetail" });


// 3️⃣ Product Line
app.MapControllerRoute(
    name: "ProductLine",
    pattern: "product-line/{slug}",
    defaults: new { controller = "Page", action = "ProductLine" });


// 4️⃣ Category (specific too)
app.MapControllerRoute(
    name: "Category",
    //pattern: "category/{slug}-{id:int}",
    pattern: "category/{id:int}",
    defaults: new { controller = "Page", action = "ViewCategoryList" });


// 5️⃣ CMS Page (generic fallback)
app.MapControllerRoute(
    name: "CMSPage",
    pattern: "{slug}",
    defaults: new { controller = "Page", action = "ViewPage" });


// 6️⃣ Default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Page}/{action=Index}/{id?}");



//.......................................................


app.Run();
