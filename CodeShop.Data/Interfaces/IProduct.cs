using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeShop.Data.Interfaces
{
    public interface IProductCreation
    {
        string Name { get; set; }
        string Description { get; set; }
        string Img { get; set; }
        bool IsPublic { get; set; }
        string CreatorId { get; set; }
    }

    public interface IProduct : IProductCreation
    {
        string Id { get; set; }
        DateTime CreatedTimestamp { get; set; }
    }
}
