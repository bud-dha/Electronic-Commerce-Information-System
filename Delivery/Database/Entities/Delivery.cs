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
        /// ID доставки.
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// ID заказа на доставку.
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// ID курьера на доставку.
        /// </summary>
        public int CourierId { get; set; }
    }
}
