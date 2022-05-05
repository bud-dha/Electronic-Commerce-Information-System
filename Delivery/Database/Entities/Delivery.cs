using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Database.Entities
{
    /// <summary>
    /// Класс доставки.
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// 
        /// </summary>
        private int count = 0;
        /// <summary>
        /// ID доставки.
        /// </summary>
        public int Id { get; } 
        /// <summary>
        /// ID заказа на доставку.
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// ID курьера на доставку.
        /// </summary>
        public int CourierId { get; set; }

        /// <summary>
        /// Создает экземпляр класса<see cref="Delivery">.
        /// </summary>
        public Delivery(int order_id, int courier_id)
        {
            Id = count++;
            OrderId = order_id;
            CourierId = courier_id;
        }
    }
}
