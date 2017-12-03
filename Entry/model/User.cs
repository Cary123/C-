using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entry.model
{
    public class User
    {
        private Guid userid;
        private string username;
        private string password;
        private char gender;
        private int age;
        private string phone;
        private DateTime lastupdatetime;
        private string email;
        private LoginState state = LoginState.Offline;
        

        public virtual Guid UserId
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }

        }

        public virtual string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }

        }

        public virtual string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }

        }

        public virtual char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }

        }

        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

        }

        public virtual string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }

        }

        public virtual DateTime LastUpdateTime
        {
            get
            {
                return lastupdatetime;
            }
            set
            {
                lastupdatetime = value;
            }

        }

        public virtual string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        public virtual LoginState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }

        }

        public virtual ISet<Order> Orders { get; set; }
    }
}
