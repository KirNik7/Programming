using System;

namespace Programming.Model.Classes
{
	public class Song
	{
		private int _duration;

		public int Duration
        {
			get 
			{ 
				return _duration; 
			}
            set
            {
				if (value < 0)
                {
					throw new ArgumentException("Ожидается продолжительность песни больше 0.");
				}
				_duration = value;
            }
        }

		public string Title { get; set; }

		public string Artist { get; set; }

		public string Album { get; set; }

		public Song(string title, string artist, string album, int duration)
        {
			Title = title;
			Artist = artist;
			Album = album;
			Duration = duration;
        }

		public Song() { }
	}
}

