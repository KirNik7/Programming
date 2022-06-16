namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
	{
		/// <summary>
		/// Продолжительность песни.
		/// </summary>
		private int _duration;

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Song"/>.
		/// </summary>
		/// <param name="title">Название песни.</param>
		/// <param name="artist">Исполнитель песни.</param>
		/// <param name="album">Альбом.</param>
		/// <param name="duration">Продолжительность песни. Должна быть положительным числом.</param>
		public Song(string title, string artist, string album, int duration)
		{
			Title = title;
			Artist = artist;
			Album = album;
			Duration = duration;
		}

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Song"/>.
		/// </summary>
		public Song() { }

		/// <summary>
		/// Возвращает и задаёт продолжительность песни. Должна быть положительным числом.
		/// </summary>
		public int Duration
        {
			get 
			{ 
				return _duration; 
			}
            set
            {
				Validator.AssertOnPositiveValue(nameof(Duration), value);
				_duration = value;
            }
        }

		/// <summary>
		/// Возвращает и задаёт название песни.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Возвращает и задаёт исполнителя песни.
		/// </summary>
		public string Artist { get; set; }

		/// <summary>
		/// Возвращает и задаёт альбом.
		/// </summary>
		public string Album { get; set; }
	}
}

