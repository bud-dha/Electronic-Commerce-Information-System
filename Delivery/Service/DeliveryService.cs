using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Database.Entities;

namespace Delivery.Service
{
    public class DeliveryService
    {
        /// <summary>
        /// Список курьеров.
        /// </summary>
        private List<Courier> _couriers;
        /// <summary>
        /// Список свободных курьеров.
        /// </summary>
        private List<Courier> _freeCouriers;

        /// <summary>
        /// Возвращает собранный заказ.
        /// Удаляет курьера из списка свободных.
        /// </summary>
        public Orrder CreateOrder(List<int> products_id, int shopper_id, Courier courier)
        {
            Orrder order = new Orrder(products_id, shopper_id);
            _freeCouriers.Remove(_freeCouriers.Find(x => x.Id == courier.Id));
            return order;
        }
        /// <summary>
        /// Возвращает состояние заказа.
        /// Добавляет курьера в список свободных.
        /// </summary>
        public bool DeliverOrder(Courier courier)
        {
            _freeCouriers.Add(_freeCouriers.Find(x => x.Id == courier.Id));
            return true;
        }
        /// <summary>
        /// Возвращает состояние заказа.
        /// Добавляет курьера в список свободного.
        /// </summary>
        public bool ReturnOrder(Courier courier)
        {
            _freeCouriers.Add(_freeCouriers.Find(x => x.Id == courier.Id));
            return true;
        }
        /// <summary>
        /// Добавляет курьера в список.
        /// </summary>
        public void AddNewCourier(Courier courier)
        {
            _couriers.Add(courier);
        }
        /// <summary>
        /// Удаляет курьера из списка.
        /// </summary>
        public void RemoveCourier(Courier courier)
        {
            _couriers.Remove(courier);
        }
    }
}
