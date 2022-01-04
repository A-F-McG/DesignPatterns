using System;
namespace StrategyPattern.ConcreteStrategies
{
    public class AttackConcreteStrategyB: IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Pull under water");
        }
    }
}
