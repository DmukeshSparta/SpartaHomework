namespace Lab2Homework
{
    class Cats
    {
        public string name;
        public int age;

        //Cat constructor  method 
        public Cats(string name, int age)
        {
            // Use this to qualify the members of the class 
            // instead of the constructor parameters.
            this.name = name;
            this.age = age;
        }
        public static void Age(Cats cat)
        {
            cat.age += 5;
            //cat.age = cat.age + 5; this code is equivalent to line 15.
        }
    }
}
