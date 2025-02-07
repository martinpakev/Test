using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class RentService : IRentService
    {
        readonly IRepository repository;

        public RentService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IEnumerable<RentServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<House>()
                .Include(h => h.Agent)
                .Include(h => h.Renter)
                .Where(h => h.RenterId != null)
                .Select(h => new RentServiceModel()
                {
                    HouseTitle = h.Title,
                    HouseImageUrl = h.ImageUrl,
                    AgentEmail = h.Agent.User.Email,
                    AgentFullName = $"{h.Agent.User.FirstName} {h.Agent.User.LastName}",
                    RenterEmail = h.Renter != null ? h.Renter.Email : string.Empty,
                    RenterFullName = h.Renter != null ? $"{h.Renter.FirstName} {h.Renter.LastName}" : string.Empty
                })
                .ToListAsync();
        }
    }
}
