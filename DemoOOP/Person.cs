namespace DemoOOP
{
    public class Person
    {
        public string Name { get; set; }
        public ushort Age { get; set; }

        public Person()
        {
        }

        public Person(string name, ushort age)
        {
            Name = name;
            Age = age;
        }
    }
}
