using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    public class Customer
    {
        public int Id;
        public string Name;

        //use readonly to avoid loss of data
        //can be initialized within class or in constructor
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()
        //{
        //    Orders = [];
        //}

        //this() -> means the default constructor would be invoked first
        public Customer(int id)
            //: this()
        {
            this.Id = id;
        }

        //this(id) would be invoked first
        public Customer(int id, string name) 
            : this(id)

        {
            this.Name = name;
        }

        public void Promote()
        {
            //readonly avoids re-initializing
            //Orders = new List<Order>();
        }
    }
}
 