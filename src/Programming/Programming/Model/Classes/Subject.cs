namespace Programming.Model.Classes
{
	/// <summary>
	/// Хранит данные о дисциплине.
	/// </summary>
    public class Subject
	{
		/// <summary>
		/// Оценка по дисциплине.
		/// </summary>
		private int _mark;

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Subject"/>.
		/// </summary>
		/// <param name="title">Название дисциплины.</param>
		/// <param name="teachersLastName">Фамилия преподавателя.</param>
		/// <param name="mark">Оценка по дисциплине. Должна быть в диапазоне от 0 до 5 (включительно).</param>
		public Subject(string title, string teachersLastName, int mark)
		{
			Title = title;
			TeacherLastName = teachersLastName;
			Mark = mark;
		}

		/// <summary>
		/// /// Создаёт экземпляр класса <see cref="Subject"/>.
		/// </summary>
		public Subject() { }

		/// <summary>
		/// Возвращает и задаёт фамилию преподавателя.
		/// </summary>
		public string TeacherLastName { get; set; }

		/// <summary>
		/// Возвращает и задаёт оценку по дисциплине. Должна быть в диапазоне от 0 до 5 (включительно).
		/// </summary>
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

		/// <summary>
		/// Возвращает и задаёт название дисциплины.
		/// </summary>
		public string Title { get; set; }
	}
}
