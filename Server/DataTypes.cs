using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class DataTypes
    {
    }

    public class OrdersView
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string UserName { get; set; }
        public DateTime DateOrder { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string PriceString
        {
            get
            {
                return Price.ToString("G29");
            }
        }
        public string DateOrderShortString
        {
            get
            {
                return DateOrder.ToShortDateString();
            }
        }
    }
}
