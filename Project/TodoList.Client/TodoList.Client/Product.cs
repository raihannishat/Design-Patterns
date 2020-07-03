using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Client
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public int? price { get; set; }
        public int? quantity { get; set; }
    }
}
