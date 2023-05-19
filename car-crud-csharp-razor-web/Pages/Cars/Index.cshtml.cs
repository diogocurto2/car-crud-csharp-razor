using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_web.Models.Cars;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace car_crud_csharp_razor_web.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly IGetListCarsUseCase _GetCarsUseCase;
        public IList<Car> Cars { get; set; } = default!;

        public IndexModel(IGetListCarsUseCase getCarsUseCase)
        {
            this._GetCarsUseCase = getCarsUseCase;            
            this.Cars = new List<Car>();
        }

        public async Task OnGetAsync()
        {
            var result = await _GetCarsUseCase.Execute(new GetListCarsUseCaseInput());
            Cars = result.Cars.Convert();

        }
    }
}
