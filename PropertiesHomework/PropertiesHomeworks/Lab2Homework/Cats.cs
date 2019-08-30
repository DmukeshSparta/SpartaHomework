namespace Lab2Homework
{
    class Cats
    {
        private string name;
        private int age;

        public Cats(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
