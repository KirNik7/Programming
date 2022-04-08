﻿using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
	public class Contact
	{
		private string _name;

		private string _surname;
		
		private string AssertStringContainsOnlyLetters(string property, string value)
        {
			if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
			{
				throw new ArgumentException($"Поле {property} должно " +
					$"содержать только символы английского алфавита.");
			}

			return value;
		}

		public string Name 
		{
            get
            {
				return _name;
            }
            set
            {
				_name = AssertStringContainsOnlyLetters(nameof(Name), value);
            }
		}

		public string Surname
		{
			get
			{
				return _surname;
			}
			set
			{
				_surname = AssertStringContainsOnlyLetters(nameof(Surname), value);
			}
		}

		public string PhoneNumber { get; set; }

		public string Email { get; set; }

		public Contact(string name, string surname, string phoneNumber, string email)
        {
			Name = name;
			Surname = surname;
			PhoneNumber = phoneNumber;
			Email = email;
        }
		
		public Contact() { }
	}
}

