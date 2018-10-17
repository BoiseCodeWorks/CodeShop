using CodeShop.Common.Interfaces;
using CodeShop.Business.Validators;
using CodeShop.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShop.Business
{
    public class ProductService
    {
        IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IProduct CreateProduct(IProductCreation data)
        {
            try
            {
                ProductValidator.Validate(data);
                return _repo.Create(data);
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
