using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Database.Entities
{
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly long Id;
        /// <summary>
        /// 
        /// </summary>
        private List<long> _productId;
        /// <summary>
        /// 
        /// </summary>
        private long _shopperId;
    }
}
