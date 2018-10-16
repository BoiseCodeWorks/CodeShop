using CodeShop.Data.Interfaces;
using CodeShop.Data.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CodeShop.Data.Repositories
{
    internal class ProductRepository
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
            var newProduct = new Product(data);
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


        #region TBD


        public ProductRepository(IDbConnection db)
        {
            _db = db;
        }
        #endregion


    }
}
