namespace HouseRentingSystem.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;

        Task<T> AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();
    }
}
