using System;
using StrategyPattern.ConcreteStrategies;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy pattern!");
            var creature = new Context(new MoveConcreteStrategyA(), new AttackConcreteStrategyA());
            Console.WriteLine("Expect creature to run and throw branch");
            creature.Move();
            creature.Attack();

            creature.SetMoveStrategy(new MoveConcreteStrategyB());
            creature.SetAttackStrategy(new AttackConcreteStrategyB());
            Console.WriteLine("Expect creature to swim and pull under water");
            creature.Move();
            creature.Attack();
        }
    }
}
