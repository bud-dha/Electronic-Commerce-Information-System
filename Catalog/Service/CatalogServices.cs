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
        Structures structures = new Structures();

        /// <summary>
        /// Добаавляет категорию.
        /// </summary>       
        public void AddCategory(Product product)
        {
            structures.Categories.Add(product.Category);
        }
        /// <summary>
        /// Добаавляет бренд.
        /// </summary>       
        public void AddBrand(Product product)
        {
            structures.Brands.Add(product.Brand);
        }
        /// <summary>
        /// Добаавляет товар.
        /// </summary>       
        public void AddProduct(Product product)
        {
            structures.Catalog.Add(product);
        }
        /// <summary>
        /// Удаляет товар.
        /// </summary>
        public void RemoveProduct(Product product)
        {
            structures.Catalog.Remove(product);
        }
        /// <summary>
        /// Возвращает каталог продуктов.
        /// </summary>
        public List<Product> GetProducts()
        {
            return structures.Catalog;
        }
    }
}
