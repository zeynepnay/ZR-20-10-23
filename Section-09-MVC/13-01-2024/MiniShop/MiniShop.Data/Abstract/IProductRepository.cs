using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //Producta özgü metot imzalarımızı buraya yazacagız.
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetHomePageProducts(bool? isHome);
    }
}
