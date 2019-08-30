namespace Lab2Homework
{
    class Cats
    {
        public string name;
        public int age;

        public Cats(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static void Age(Cats cat)
        {
            cat.age += 5;
        }
    }
}
