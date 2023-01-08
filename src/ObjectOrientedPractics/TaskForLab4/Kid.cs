namespace TaskForLab4
{
    class Kid : Person
    {
        private string _favoriteToy;

        public Kid(string firstName,
                   string lastName,
                   int age,
                   string favoriteToy) : base(firstName, lastName, age)
        {
            FavoriteToy = favoriteToy;
        }

        public string FavoriteToy
        {
            get
            {
                return _favoriteToy;
            }

            set
            {
                _favoriteToy = value;
            }
        }
    }
}
