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
				Validator.AssertOnPositiveValue(nameof(Duration), value);
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

