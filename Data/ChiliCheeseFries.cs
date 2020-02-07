using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries: Side
    {
        public double Price
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 1.99;
                }
                else if(this.Size == Size.Medium)
                {
                    return 2.99;
                }
            }
        }
    }
}
