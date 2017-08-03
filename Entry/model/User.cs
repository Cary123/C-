using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class User
    {
        public virtual Guid UserId
        {
            get;
            set;
        }

        public virtual string Username
        {
            get;
            set;
        }

        public virtual string Password { get; set; }

        public virtual char Gender
        {
            get;
            set;
        }

        public virtual int Age
        {
            get;
            set;
        }

        public virtual string Phone
        {
            get;
            set;
        }

        public virtual DateTime LastLoginTime
        {
            get;
            set;
        }

        public virtual string Email
        {
            get;
            set;
        }

    }
}
