using BulkyBookWeb.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        void Save();
    }
}