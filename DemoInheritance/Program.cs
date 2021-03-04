using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Camel camel = new Camel();
            Person person = new Person();
            Lion lion = new Lion();
            Snake snake = new Snake();

            person.Drink();
            person.Eat();
            person.Hunt();

            lion.Drink();
            lion.Eat();
            lion.Hunt();

            snake.Drink();
            snake.Eat();
            snake.Hunt();

        }
    }
}
