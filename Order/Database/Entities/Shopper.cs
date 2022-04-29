using System;

/// <summary>
/// Класс покупателя.
/// </summary>
public class Shopper
{
    /// <summary>
    /// Счетчик для Id.
    /// </summary>
    private int count = 0;
    /// <summary>
    /// покупателя.
    /// </summary>
    public int Id { get;}
    /// <summary>
    /// Имя покупателя.
    /// </summary>
	public string Name { get; set; }
    /// <summary>
    /// Фамилия покупателя.
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Адресс покупателя.
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Номер телефона покупателя.
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// Почта покупателя.
    /// </summary>
    public string Mail { get; set; }

    /// <summary>
	/// Создает экземпляр класса<see cref="Shopper">.
	/// </summary>
    public Shopper(string name, string surname, string address, string phone_number, string mail)
    {
        Id = count++;
        Name = name;
        Surname = surname;
        Address = address;
        PhoneNumber = phone_number;
        Mail = mail;    
    }
}

