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
				Validator.AssertValueInRange(nameof(Mark), value, 0, 5);
				_mark = value;
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
