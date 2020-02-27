using FluentNHibernate.Conventions.Inspections;
using System;

namespace Product.Entity
{
    public class Items
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        
        public float Price { get; set; }

    }
}
