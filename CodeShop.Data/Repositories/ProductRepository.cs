using CodeShop.Common.Entities;
using CodeShop.Common.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CodeShop.Data.Repositories
{
    public interface IProductRepository
    {
        IProduct Create(IProductCreation data);
    }

    public class ProductRepository : IProductRepository
    {

        IDbConnection _db;

        #region SQLCOMMANDS


        /**
         * CREATE
         * READ
         * UPDATE
         * DESTROY
         */
        public IProduct Create(IProductCreation data)
        {
            var newProduct = new Product {
                Id = Guid.NewGuid().ToString(),
                Name = data.Name,
                Description = data.Description,
                Img = data.Img,
                CreatorId = data.CreatorId,
                IsPublic = data.IsPublic,
                CreatedTimestamp = DateTimeOffset.Now
            };
            var successful = _db.ExecuteAsync(@"
                INSERT INTO products 
                (id, name, description, img, isPublic, creatorId, createdTimestamp)
                VALUES (@Id, @Name, @Description, @Img, @IsPublic, @CreatorId, @CreatedTimestamp);
            ", newProduct);
            
            if(successful.Result == 1)
            {
                return newProduct;
            }
            return null;
        }

        internal IEnumerable<IProduct> GetProducts()
        {
            return _db.Query<Product>("SELECT * FROM products;");
        }

        #endregion


        public ProductRepository(IDbConnection db)
        {
            _db = db;
        }


    }
}
