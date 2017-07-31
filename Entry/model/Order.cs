using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class Order
    {
        public virtual string OrderId { get; set; }
        public virtual string UserId { get; set; }
        public virtual DateTime OrderDate { get; set; }
    }
}
