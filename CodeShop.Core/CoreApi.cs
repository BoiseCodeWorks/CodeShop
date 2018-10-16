using CodeShop.Core.Validators;
using CodeShop.Data;
using CodeShop.Common.Interfaces;
using System;

namespace CodeShop.Core
{
    public class CoreApi
    {

        private readonly DataApi api = new DataApi(DbConnectionOptions.ConnectToMySQL("someconnection"));

        public IProduct CreateProduct(IProductCreation data)
        {
            try
            {
                ProductValidator.Validate(data);
                return api.CreateProduct(data);
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
