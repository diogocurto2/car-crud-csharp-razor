using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_web.Models.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace car_crud_csharp_razor_web.Pages.Cars
{
    public class DeleteModel : PageModel
    {
        private readonly IRemoveCarUseCase _RemoveCarUseCase;
        private readonly IGetCarUseCase _GetCarUseCase;

        public DeleteModel(IRemoveCarUseCase removeCarUseCase, IGetCarUseCase getCarUseCase)
        {
            _GetCarUseCase = getCarUseCase;
            _RemoveCarUseCase = removeCarUseCase;
        }

        [BindProperty]
      public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = await _GetCarUseCase.Execute(new GetCarUseCaseInput(id.Value));
            if (result == null)
            {
                return NotFound();
            }
            Car = result.Car.Convert();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _RemoveCarUseCase.Execute(new RemoveCarUseCaseInput(id.Value));

            return RedirectToPage("./Index");
        }
    }
}
