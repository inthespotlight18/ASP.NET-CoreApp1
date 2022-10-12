//DZ220914 - ASP.NET-CoreApp1

//Version : 1.1
//Release : September 18, 2022

//Re : CoreApp1 - first ASP.NET project                                                                     

//Update : DZ220918 - Release folder added, documentation section created

//Update : DZ220925 - link to the tutorial of creating asp.net project added

/**************************************************************************************************************************************************************
 * 
 * Link to the tutorial of creating asp.net project https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022
 * 
 **************************************************************************************************************************************************************/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
