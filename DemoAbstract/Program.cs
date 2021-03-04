using System;

namespace DemoAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            var snake = new Snake();

            bird.Go();
            bird.Run();
            snake.Go();
            snake.Run();
        }
    }
}
