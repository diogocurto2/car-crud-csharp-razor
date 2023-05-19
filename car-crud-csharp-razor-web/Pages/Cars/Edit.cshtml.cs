using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_web.Models.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace car_crud_csharp_razor_web.Pages.Cars
{
    public class EditModel : PageModel
    {
        private readonly IEditCarUseCase _EditCarsUseCase;
        private readonly IGetCarUseCase _GetCarUseCase;

        public EditModel(IEditCarUseCase editCarUseCase, IGetCarUseCase getCarUseCase)
        {
            _GetCarUseCase = getCarUseCase;
            _EditCarsUseCase = editCarUseCase;
        }

        [BindProperty]
        public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result =  await _GetCarUseCase.Execute(new GetCarUseCaseInput(id.Value));
            if (result == null)
            {
                return NotFound();
            }
            Car = result.Car.Convert();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _EditCarsUseCase.Execute(
                    new EditCarUseCaseInput(
                        Car.Id,
                        Car.Make,
                        Car.Model,
                        Car.Year,
                        Car.Doors,
                        Car.Color,
                        Car.Price));
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToPage("./Index");
        }

    }
}
