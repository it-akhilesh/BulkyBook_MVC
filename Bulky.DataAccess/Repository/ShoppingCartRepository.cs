using BulkyBook.Models;
using BulkyBookWeb.DataAccess.Repository.IRepository;
using BulkyBookWeb.DataAcess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBookWeb.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCarty>,IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }


        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
