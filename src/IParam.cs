namespace SunceSlobode.Prototype
{
    /// <summary>
    /// Представляет произвольный параметр.
    /// </summary>
    public interface IParam : IVisibility
    {
        /// <summary>
        /// Тип параметра.
        /// </summary>
        ParamType Type { get; }

        /// <summary>
        /// Значение параметра.
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Неточность определения параметра для пользователя.
        /// </summary>
        Fraction Inaccuracy { get; set; }
    }
}
