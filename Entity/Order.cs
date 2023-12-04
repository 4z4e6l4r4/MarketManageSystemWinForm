using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    // Order, Id, UserId,OrderDateTine,IsDelete
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public DateTime OrderDateTine { get; set; }
        public bool IsDelete { get; set; }
        public List<SellProduct> SellProductList { get; set; }
    }
}
