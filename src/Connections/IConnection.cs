namespace SunceSlobode.Prototype.Connections
{
    /// <summary>
    /// Представляет связь в системе взаимосвязей.
    /// </summary>
    public interface IConnection : IUpdate, IVisibility
    {
        /// <summary>
        /// Параметр, который изменяет данная связь.
        /// </summary>
        IParam Target { get; }

        /// <summary>
        /// Параметр, показывающий, активна ли данная связь.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Узел, в который входит данная связь.
        /// </summary>
        IJoint Terminator { get; }
    }
}
