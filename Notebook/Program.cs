var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Program.cs
//وظیفه اجرای برنامه را بر عهده دارد و اینکه با توجه به محیطی که در آن کار میکنیم تنظیمات مربوط به بالا اومدن اپلیکیشن مارا انجام میدهد


//Startup.cs
//این فایل در دانت نت 6 حذف و به لطف C# 10 و امکان top level statement تمام تنظیمات در همین فایل program.cs انجام شده