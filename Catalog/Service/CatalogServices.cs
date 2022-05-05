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
        /// Добаавляет категорию.
        /// </summary>       
        public void AddCategory(Product product)
        {
            Structures.Categories.Add(product.Category);
        }
        /// <summary>
        /// Добаавляет бренд.
        /// </summary>       
        public void AddBrand(Product product)
        {
            Structures.Brands.Add(product.Brand);
        }
        /// <summary>
        /// Добаавляет товар.
        /// </summary>       
        public void AddProduct(Product product)
        {
            Structures.Catalog.Add(product);
        }
        /// <summary>
        /// Удаляет товар.
        /// </summary>
        public void RemoveProduct(Product product)
        {
            Structures.Catalog.Remove(product);
        }
        /// <summary>
        /// Возвращает каталог продуктов.
        /// </summary>
        public List<Product> GetProducts()
        {
            return Structures.Catalog;
        }
    }
}
