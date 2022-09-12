using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenta.Core.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public decimal price { get; set; }

        public DateTime createdAt { get; set; }


    }
}
