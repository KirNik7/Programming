namespace TaskForLab4
{
    class Student : Person
    {
        private int _course;
        private float _averageMark;

        public Student(string firstName,
                       string lastName,
                       int age,
                       int course,
                       float averageMark) : base(firstName, lastName, age)
        {
            Course = course;
            AverageMark = averageMark;
        }

        public int Course
        {
            get
            {
                return _course;
            }

            set
            {
                if (value > 0)
                {
                    _course = value;
                }
                else
                {
                    throw new ArgumentException("Course must be greater then 0");
                }
            }
        }

        public float AverageMark
        {
            get
            {
                return _averageMark;
            }

            set
            {
                if (value > 0)
                {
                    _averageMark = value;
                }
                else
                {
                    throw new ArgumentException("Average mark must be greater then 0");
                }
            }
        }
    }
}
