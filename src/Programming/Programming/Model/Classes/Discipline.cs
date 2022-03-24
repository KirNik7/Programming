namespace Programming.Model.Classes
{
	public class Discipline
	{
		private int _mark;

		public int Mark
        {
			get { return _mark; }
            set
            {
				if (value < 0 || value > 5)
                {
					throw new ArgumentException("Ожидается оценка больше 0 и меньше или равно 5.");
				}
            }
        }

		public string Title { get; set; }

		public string TeachersLastName { get; set; }
	}
}
