using CodeShop.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShop.Common.Entities
{
    public class Product : IProduct
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedTimestamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public bool IsPublic { get; set; }
        public string CreatorId { get; set; }
    }
}
