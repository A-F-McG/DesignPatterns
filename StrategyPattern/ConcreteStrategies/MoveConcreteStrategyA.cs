using System;
namespace StrategyPattern
{
    public class MoveConcreteStrategyA: IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
