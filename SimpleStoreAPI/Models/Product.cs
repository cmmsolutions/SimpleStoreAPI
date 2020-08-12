using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleStoreAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }

        /// <summary>
        /// This is to stop a circular reference
        /// </summary>
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}
