using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class HouseController : AdminBaseController
    {
        private readonly IHouseService houseService;
        private readonly IAgentService agentService;

        public HouseController(IHouseService houseService, IAgentService agentService)
        {
            this.houseService = houseService;
            this.agentService = agentService;
        }
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            int agentId = await agentService.GetAgentIdAsync(userId) ?? 0;

            var mineHouses = new MyHousesViewModel()
            {
                AddedHouses = await houseService.AllHousesByAgentIdAsync(agentId),
                RentedHouses = await houseService.AllHousesByUserIdAsync(userId),
            };

            return View(mineHouses);
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await houseService.GetUnApprovedAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int houseId)
        {
            await houseService.ApproveHouseAsync(houseId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
