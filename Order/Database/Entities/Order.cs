using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Database.Entities
{
    /// <summary>
    /// Класс заказа.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// ID заказа.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Список ID продуктов.
        /// </summary>
        public List<int> ProductsId;
        /// <summary>
        /// ID покупателя
        /// </summary>
        public int ShopperId { get; set; }
    }
}
