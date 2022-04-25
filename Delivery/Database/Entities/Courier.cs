using System;

/// <summary>
/// Класс курьера.
/// </summary>
public class Courier
{
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
}
