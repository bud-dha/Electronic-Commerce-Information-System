using System;
using System.Collections.Generic;

/// <summary>
/// Класс продукта.
/// </summary>
public class Product
{
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
}

