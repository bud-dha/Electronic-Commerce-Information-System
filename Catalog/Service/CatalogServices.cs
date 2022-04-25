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
        public void AddProduct(Product product)
        {
            catalog.products.Add(product);
        }
        /// <summary>
        /// Удаляет товар.
        /// </summary>
        public void RemoveProduct(Product product)
        {
            catalog.products.Remove(product);
        }
        /// <summary>
        /// Возвращает продукт с заданным ID.
        /// </summary>
        public Product FindProduct(long id)
        {
            Product product = catalog.products.Find(x => x.Id == id);
            return product;
        }
        /// <summary>
        /// Возвращает продукт с заданным названием.
        /// </summary>
        public Product FindProduct(string name)
        {
            Product product = catalog.products.Find(x => x.Name == name);
            return product;
        }
        /// <summary>
        /// Возвращает список продуктов с заданным брендом.
        /// </summary>
        public List<Product> FindProduct(Brand brand)
        {
            List<Product> brand_products = null;
            for (int i = 0; i < catalog.products.Count; i++)
            {
                brand_products.Add(catalog.products.Find(x => x.Brand == brand));
            }
            return brand_products;
        }
        /// <summary>
        /// Возвращает список продуктов с заданной категорией.
        /// </summary>
        public List<Product> FindProduct(Category category)
        {
            List <Product> category_products = null;
            for (int i = 0; i < catalog.products.Count; i++)
            {
               category_products.Add(catalog.products.Find(x => x.Category == category));
            }
            return category_products;
        }
        /// <summary>
        /// Возвращает каталог продуктов.
        /// </summary>
        public Catalog GetProducts()
        {
            return catalog;
        }

    }
}
