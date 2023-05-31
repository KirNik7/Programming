﻿namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает копию экземпляра класса <see cref="Contact"/>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }
    }
}