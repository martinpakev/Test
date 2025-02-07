using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class RentController : AdminBaseController
    {
        private readonly IRentService rentService;

        public RentController(IRentService rentService)
        {
            this.rentService = rentService;
        }
        public async Task<IActionResult> All()
        {
            var model = await rentService.AllAsync();

            return View(model);
        }
    }
}
