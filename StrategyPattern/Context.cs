using System;
namespace StrategyPattern
{
    public class Context
    {
        private IMoveStrategy _moveStrategy;
        private IAttackStrategy _attackStrategy;

        public Context(IMoveStrategy moveStrategy, IAttackStrategy attackStrategy)
        {
            _moveStrategy = moveStrategy;
            _attackStrategy = attackStrategy;
        }

        public void SetMoveStrategy(IMoveStrategy moveStrategy)
        {
            _moveStrategy = moveStrategy;
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Move()
        {
            _moveStrategy.Move();
        }

        public void Attack()
        {
            _attackStrategy.Attack();
        }
    }
}
