using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Entities.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
