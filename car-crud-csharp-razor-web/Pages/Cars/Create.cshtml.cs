using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_web.Models.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace car_crud_csharp_razor_web.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly ICreateCarUseCase _CreateCarsUseCase;

        public CreateModel(ICreateCarUseCase createCarsUseCase)
        {
            _CreateCarsUseCase = createCarsUseCase;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || Car == null)
            {
                return Page();
            }

            await _CreateCarsUseCase.Execute(
                new CreateCarUseCaseInput(
                    Car.Make, 
                    Car.Model,
                    Car.Year,
                    Car.Doors,
                    Car.Color,
                    Car.Price)
                );

            return RedirectToPage("./Index");
        }
    }
}
