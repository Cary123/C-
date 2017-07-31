using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class OrderProduct
    {
        public virtual string OrderId { get; set; }
        public virtual string ProductId { get; set; }
    }
}
