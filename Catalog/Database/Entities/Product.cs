using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class Product
{
	/// <summary>
	/// Id продукта.
	/// </summary>
	private long _id; 
	/// <summary>
	/// Название продукта.
	/// </summary>
	private string _name;
	/// <summary>
	/// Ценв продукта.
	/// </summary>
	private double _price;
	/// <summary>
	/// Брэнд продукта.
	/// </summary>
	private Brand _brand;
	/// <summary>
	/// Категория продукта.
	/// </summary>
	private Category _category;


	public long Id { get; set; }
	public string Name { get; set; }
	public Brand Brand { get; set; }
	public Category Category { get; set; }

}

