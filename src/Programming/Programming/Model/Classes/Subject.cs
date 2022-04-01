using System;

namespace Programming.Model.Classes
{
	public class Subject
	{
		private int _mark;

		public int Mark
        {
			get 
			{ 
				return _mark; 
			}
            set
            {
				if (value < 0 || value > 5)
                {
					throw new ArgumentException("Ожидается оценка больше 0 и меньше или равно 5.");
				}
            }
        }

		public string Title { get; set; }

		public string TeacherLastName { get; set; }

		public Subject(string title, string teachersLastName, int mark)
        {
			Title = title;
			TeacherLastName = teachersLastName;
			Mark = mark;
        }

		public Subject() { }
	}
}
