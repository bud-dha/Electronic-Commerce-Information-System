using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Service
{
    public class CatalogServices
    {
        /// <summary>
        /// Список продуктов.
        /// </summary>
        public List<Product> catalog;
        /// <summary>
        /// Список категорий.
        /// </summary>
        public List<string> categories;
        /// <summary>
        /// Список брендов.
        /// </summary>
        public List<string> brands;

        /// <summary>
        /// Добаавляет категорию.
        /// </summary>       
        public void AddCategory(Product product)
        {
            categories.Add(product.Category);
        }
        /// <summary>
        /// Добаавляет бренд.
        /// </summary>       
        public void AddBrand(Product product)
        {
            brands.Add(product.Brand);
        }
        /// <summary>
        /// Добаавляет товар.
        /// </summary>       
        public void AddProduct(Product product)
        {
            catalog.Add(product);
        }
        /// <summary>
        /// Удаляет товар.
        /// </summary>
        public void RemoveProduct(Product product)
        {
            catalog.Remove(product);
        }
        /// <summary>
        /// Возвращает каталог продуктов.
        /// </summary>
        public List<Product> GetProducts()
        {
            return catalog;
        }
    }
}
