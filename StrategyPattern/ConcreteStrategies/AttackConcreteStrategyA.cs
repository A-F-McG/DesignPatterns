using System;
namespace StrategyPattern.ConcreteStrategies
{
    public class AttackConcreteStrategyA: IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Throw branch");
        }
    }
}
