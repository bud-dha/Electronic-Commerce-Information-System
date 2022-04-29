using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Database.Entities;
using Catalog;

namespace Order.Service
{
    public class OrderService
    {
        Structures structures = new Structures();

        /// <summary>
        /// Создает заказ.
        /// </summary>
        public Orrder CreateOrder(List<int> products_id, int shopper_id)
        {
            Orrder order = new Orrder(products_id, shopper_id);
            return order;
        }
        //Доделать
        /// <summary>
        /// Отменяет заказ.
        /// </summary>
        public Orrder CreateOrder(Orrder order)
        {
            return order;
        }
        /// <summary>
        /// Возвращает продукт с заданным ID.
        /// </summary>
        public Product FindProduct(long id)
        {
            Product product = structures.Catalog.Find(x => x.Id == id);
            return product;
        }
        /// <summary>
        /// Возвращает продукт с заданным названием.
        /// </summary>
        public Product FindProduct(string name)
        {
            Product product = structures.Catalog.Find(x => x.Name == name);
            return product;
        }
        /// <summary>
        /// Возвращает список продуктов с заданным брендом.
        /// </summary>
        public List<Product> FindProductByBrand(string brand)
        {
            List<Product> brand_products = null;

            for (int i = 0; i < structures.Catalog.Count; i++)
            {
                brand_products.Add(structures.Catalog.Find(x => x.Brand == brand));
            }
            return brand_products;
        }
        /// <summary>
        /// Возвращает список продуктов с заданной категорией.
        /// </summary>
        public List<Product> FindProductByCategory(string category)
        {
            List<Product> category_products = null;

            for (int i = 0; i < structures.Catalog.Count; i++)
            {
                category_products.Add(structures.Catalog.Find(x => x.Category == category));
            }
            return category_products;
        }
    }
}
