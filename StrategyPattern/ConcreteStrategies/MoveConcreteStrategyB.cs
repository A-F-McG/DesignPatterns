using System;
namespace StrategyPattern
{
    public class MoveConcreteStrategyB: IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
