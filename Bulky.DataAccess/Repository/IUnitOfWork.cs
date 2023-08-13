using BulkyBookWeb.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicatioUserRepository ApplicatioUser { get; }
        void Save();
    }
}