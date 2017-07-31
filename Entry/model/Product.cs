using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class Product
    {
        public virtual string ProductId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Version { get; set; }
        public virtual float Price { get; set; }
    }
}
