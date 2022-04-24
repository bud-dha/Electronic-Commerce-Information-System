using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Service
{
    public class CatalogServices
    {
        Catalog catalog = new Catalog();

        /// <summary>
        /// Добаавляет товар.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            catalog.products.Add(product);
        }
        /// <summary>
        /// Удаляет товар.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct(Product product)
        {
            catalog.products.Remove(product);
        }
        /// <summary>
        /// Возвращает продукт с заданным ID.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Product FindProduct(long id)
        {
            Product product = catalog.products.Find(x => x.Id == id);
            return product;
        }
        /// <summary>
        /// Возвращает продукт с заданным названием.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Product FindProduct(string name)
        {
            Product product = catalog.products.Find(x => x.Name == name);
            return product;
        }
        /// <summary>
        /// Возвращает продукт с заданным брендом.
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public Product FindProduct(Brand brand)
        {
            Product product = catalog.products.Find(x => x.Brand == brand);
            return product;
        }
        /// <summary>
        /// Возвращает продукт с заданной категорией.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Product FindProduct(Category category)
        {
            Product product = catalog.products.Find(x => x.Category == category);
            return product;
        }
        /// <summary>
        /// Возвращает каталог продуктов.
        /// </summary>
        /// <returns></returns>
        public Catalog GetProducts()
        {
            return catalog;
        }

    }
}
