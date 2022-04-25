using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Database.Entities
{
    /// <summary>
    /// Класс заказа.
    /// </summary>
    public class Orrder
    {
        /// <summary>
        /// Счетчик для присвоения Id.
        /// </summary>
        private int count = 0;
        /// <summary>
        /// ID заказа.
        /// </summary>
        public int Id { get;}
        /// <summary>
        /// Список ID продуктов.
        /// </summary>
        public List<int> ProductsId;
        /// <summary>
        /// ID покупателя
        /// </summary>
        public int ShopperId { get; set; }

        /// <summary>
        /// Создает экземпляр класса<see cref="Orrder">.
        /// </summary>
        public Orrder(List<int> products_id, int shopper_id)
        {
            Id = count++;
            ProductsId = products_id;
            ShopperId = shopper_id;
        }
    }
}
