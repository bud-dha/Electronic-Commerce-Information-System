using System;

/// <summary>
/// Класс продовца.
/// </summary>
public class Seller
{
    /// <summary>
    /// Счетчик для Id.
    /// </summary>
    private int count = 0;
    /// <summary>
    /// ID продавца.
    /// </summary>
    public int Id { get; }
    /// <summary>
    /// Имя продавца.
    /// </summary>
	public string Name { get; set; }
    /// <summary>
    /// Фамилия продавца.
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
	/// Создает экземпляр класса<see cref="Seller">.
	/// </summary>
	public Seller(string name, string surname)
    {
        Id = count++;
        Name = name;
        Surname = surname;
    }
}