using Comp123_S1_Group1_L6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S1_Group1_L9
{
   
    public class CustomerAddedEventArgs
    {

      
        public Customer NewCustomer { get; }

       
        public CustomerAddedEventArgs(Customer newCustomer)
        {
            NewCustomer = newCustomer;
        }
    }
}
