using System;

/// <summary>
/// Класс курьера.
/// </summary>
public class Courier
{
    /// <summary>
    /// Cчетчик для Id.
    /// </summary>
    private int count = 0;
    /// <summary>
    /// ID курьера.
    /// </summary>
    public int Id { get; }
    /// <summary>
    /// Имя курьера.
    /// </summary>
	public string Name { get; set; }
    /// <summary>
    /// Фамилия курьера.
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Номер телефона курьера.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Создает экземпляр класса<see cref="Courier">.
    /// </summary>
    public Courier(string name, string surname, string phone_number)
    {
        Id = count++;
        Name = name;
        Surname = surname;        
        PhoneNumber = phone_number;
    }
}
