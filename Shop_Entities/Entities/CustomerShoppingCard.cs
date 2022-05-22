using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Entities.Entities
{
    public class CustomerShoppingCard : IEntity
    {
        public int Id { get; set; }
        public Dictionary<string, int> Customer { get; set; }
        public Dictionary<string, int> Product { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
