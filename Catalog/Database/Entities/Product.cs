using System;
using System.Collections.Generic;

/// <summary>
/// Класс продукта.
/// </summary>
public class Product
{
	/// <summary>
	/// Счетчик для Id.
	/// </summary>
	private int count = 0;
	/// <summary>
	/// Id продукта.
	/// </summary>
	public int Id { get; }
	/// <summary>
	/// Название продукта.
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// Ценв продукта.
	/// </summary>
	public double Price { get; set; }
	/// <summary>
	/// Брэнд продукта.
	/// </summary>
	public string Brand { get; set; }
	/// <summary>
	/// Категория продукта.
	/// </summary>
	public string Category { get; set; }

	/// <summary>
	/// Создает экземпляр класса<see cref="Product">.
	/// </summary>
	public Product(string name, double price, string brand, string category)
	{
		Id = count++;
		Name = name;
		Price = price;
		Brand = brand;
		Category = category;
	}
}

