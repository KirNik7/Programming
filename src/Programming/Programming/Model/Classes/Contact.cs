using System;

namespace Programming.Model.Classes
{
	public class Contact
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		public string Email { get; set; }

		public Contact(string firstName, string lastName, string phoneNumber, string email)
        {
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;
        }
		
		public Contact() { }
	}
}

