using Proyecto1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<UserService>(serv => serv.BaseAddress = new Uri("http://localhost:5015/api/v1/"));
builder.Services.AddHttpClient<ClienteService>(serv => serv.BaseAddress = new Uri("http://localhost:5015/api/v1/"));
builder.Services.AddHttpClient<CategoriaService>(serv => serv.BaseAddress = new Uri("http://localhost:5015/api/v1/"));
builder.Services.AddHttpClient<ProductoService>(serv => serv.BaseAddress = new Uri("http://localhost:5015/api/v1/"));
builder.Services.AddHttpClient<PeticionService>(serv => serv.BaseAddress = new Uri("http://localhost:5015/api/v1/"));
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
