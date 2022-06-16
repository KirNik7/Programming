namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
	{
		/// <summary>
		/// Имя.
		/// </summary>
		private string _name;

		/// <summary>
		/// Фамилия.
		/// </summary>
		private string _surname;

		/// <summary>
		/// Возвращает и задаёт имя для контакта. Должно состоять только из букв английского алфавита.
		/// </summary>
		public string Name 
		{
            get
            {
				return _name;
            }
            set
            {
				Validator.AssertStringContainsOnlyLetters(nameof(Name), value);
				_name = value;
			}
		}

		/// <summary>
		/// Возвращает и задаёт фамилию для контакта. Должно состоять только из букв английского алфавита.
		/// </summary>
		public string Surname
		{
			get
			{
				return _surname;
			}
			set
			{
				Validator.AssertStringContainsOnlyLetters(nameof(Surname), value);
				_surname = value;
			}
		}

		/// <summary>
		/// Возвращает и задаёт номер телефона.
		/// </summary>
		public string PhoneNumber { get; set; }

		/// <summary>
		/// Возвращает и задаёт адрес электронной почты.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Contact"/>.
		/// </summary>
		/// <param name="name">Имя. Должно состоять только из букв английского алфавита.</param>
		/// <param name="surname">Фамилия. Должно состоять только из букв английского алфавита.</param>
		/// <param name="phoneNumber">Номер.</param>
		/// <param name="email">Адрес электронной почты.</param>
		public Contact(string name, string surname, string phoneNumber, string email)
        {
			Name = name;
			Surname = surname;
			PhoneNumber = phoneNumber;
			Email = email;
        }
		
		/// <summary>
		/// Создаёт экземпляр класса <see cref="Contact"/>. 
		/// </summary>
		public Contact() { }
	}
}

