using CodeShop.Data.Interfaces;
using CodeShop.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CodeShop.Data
{
    public sealed class DataApi
    {

        private readonly ProductRepository _productRepo;

        public DataApi(IDbConnection db)
        {
            _productRepo = new ProductRepository(db);
        }

        public IEnumerable<IProduct> GetProducts()
        {
            return _productRepo.GetProducts();
        }

        public IProduct CreateProduct(IProductCreation data)
        {
            return _productRepo.Create(data);
        }

    }
}
