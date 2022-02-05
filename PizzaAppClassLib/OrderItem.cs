using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppClassLib
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Pizza Pizza { get; set; }
    }
}
