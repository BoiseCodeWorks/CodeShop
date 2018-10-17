using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeShop.Common.Interfaces
{
    public interface IProductCreation
    {
        [Required]
        string Name { get; set; }
        [Required]
        [MinLength(42)]
        string Description { get; set; }
        [Url]
        string Img { get; set; }
        bool IsPublic { get; set; }
        string CreatorId { get; set; }
    }

    public interface IProduct : IProductCreation
    {
        string Id { get; set; }
        DateTimeOffset CreatedTimestamp { get; set; }
    }
}
