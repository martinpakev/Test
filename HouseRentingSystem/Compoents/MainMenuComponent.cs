using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HouseRentingSystem.Compoents
{
    public class MainMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
