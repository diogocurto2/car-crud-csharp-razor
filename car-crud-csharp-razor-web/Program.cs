using car_crud_csharp_razor_infra;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases;
using car_crud_csharp_razor_services.UseCases.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IGetListCarsUseCase, GetListCarsUseCase>();
builder.Services.AddSingleton<IGetCarUseCase, GetCarUseCase>();
builder.Services.AddSingleton<ICreateCarUseCase, CreateCarUseCase>();
builder.Services.AddSingleton<IRemoveCarUseCase, RemoveCarUseCase>();
builder.Services.AddSingleton<IEditCarUseCase, EditCarUseCase>();
builder.Services.AddSingleton<ICarsRepository, CarsRepositoryInMemory>();

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

