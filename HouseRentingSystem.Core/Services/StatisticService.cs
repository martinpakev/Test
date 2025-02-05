using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Statistic;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IRepository repository;

        public StatisticService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<StatisticServiceModel> TotalAsync()
        {
            int total = await repository.AllReadOnly<House>()
                .Where(h => h.IsApproved)
                .CountAsync();

            int rented = await repository.AllReadOnly<House>()
                .CountAsync(h => h.RenterId != null);

            return new StatisticServiceModel()
            {
                TotalHouses = total,
                TotalRents = rented
            };
        }
    }
}
