using Comp123_S1_Group1_L6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S1_Group1_L9
{
    internal class Chees : MenuItemAddition
    {
     
        public Chees(IMenuItem menuItem) : base(menuItem)
        {
            Description = "Chees";
            BaseCost = 0.40M;
        }
    }
}
