using CodeShop.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShop.Core.Validators
{
    internal static class ProductValidator
    {
        public static bool Validate(IProductCreation data)
        {

            if (string.IsNullOrWhiteSpace(data.Name))
            {
                throw new FormatException("[BAD NAME] Please provide a name for the product");
            }

            if(data.Name == "Hello Kitty")
            {
                throw new Exception("No kitties please");
            }



            return true;
        }


    }
}
