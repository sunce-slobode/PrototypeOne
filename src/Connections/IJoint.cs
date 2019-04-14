using System.Collections.Generic;

namespace SunceSlobode.Prototype.Connections
{
    /// <summary>
    /// Представляет узел в системе взаимосвязей.
    /// </summary>
    public interface IJoint : ICollection<IConnection>, IUpdate
    {
        /// <summary>
        /// Идентификационный номер узла.
        /// </summary>
        ID DataNumber { get; }
    }
}
