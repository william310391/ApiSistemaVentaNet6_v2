using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaVenta.Core.Entities
{
    [Table("Product")]
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public decimal price { get; set; }

        public DateTime createdAt { get; set; }


    }
}
