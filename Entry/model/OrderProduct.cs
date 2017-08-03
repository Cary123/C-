using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class OrderProduct
    {
        public virtual Guid OrderId { get; set; }
        public virtual Guid ProductId { get; set; }
        public string Detail { get; set; }
    }
}
