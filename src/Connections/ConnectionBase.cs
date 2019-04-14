namespace SunceSlobode.Prototype.Connections
{
    /// <summary>
    /// Базовый класс для связей.
    /// </summary>
    public abstract class ConnectionBase : IConnection
    {
        private IConnectionFormula p_behavior;

        public IParam Target { get; }       
        public IJoint Terminator { get; }
        public abstract int Visibility { get; set; }
        public abstract bool IsActive { get; set; }
        
        public virtual void Update()
        {
            if (p_behavior != null)
                p_behavior.Perform();
        }

        /// <summary>
        /// Устанавливает формулу, описывающую поведение связи.
        /// </summary>
        public virtual void SetFormula(IConnectionFormula formula) => p_behavior = formula;

        public ConnectionBase(IJoint terminator, IParam target)
        {
            Terminator = terminator;
            Target = target;
            p_behavior = null;
        }

        public ConnectionBase(IJoint terminator, IParam target, IConnectionFormula formula) : this(terminator, target)
            => p_behavior = formula;
        
    }
}
