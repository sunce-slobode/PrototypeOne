namespace SunceSlobode.Prototype
{
    public class BasicParam : IParam
    {
        public ParamType Type { get; }
        public virtual object Value { get; set; }
        public Fraction Inaccuracy { get; set; }
        public int Visibility { get; set; }

        public BasicParam(ParamType type, object value, int visibility = 0)
        {
            Type = type;
            Value = value;
            Visibility = visibility;
            Inaccuracy = 0.0;
        }

        public BasicParam(ParamType type, object value, Fraction inaccuracy, int visibility = 0) : this(type, value, visibility)
        {
            Inaccuracy = inaccuracy;
        }
    }
}
