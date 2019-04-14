using System;

namespace SunceSlobode.Prototype
{
    /// <summary>
    /// Структура, содержащая вещественное значение в интервале [0 ; 1]
    /// </summary>
    public struct Fraction
    {
        private double s_val;
        

        public static implicit operator Fraction(double d) => new Fraction(d);
        public static implicit operator double(Fraction f) => f.s_val;
        public static bool operator ==(Fraction f1, Fraction f2) => f1.s_val == f2.s_val;
        public static bool operator !=(Fraction f1, Fraction f2) => f1.s_val != f2.s_val;
        public static bool operator >(Fraction f1, Fraction f2) => f1.s_val > f2.s_val;
        public static bool operator <(Fraction f1, Fraction f2) => f1.s_val < f2.s_val;
        public static bool operator >=(Fraction f1, Fraction f2) => f1.s_val >= f2.s_val;
        public static bool operator <=(Fraction f1, Fraction f2) => f1.s_val <= f2.s_val;
        //TODO: доделать перегрузку всех операторов (нужно ли, правда?)
        private static bool Validate(double d)
        {
            if ((d >= 0) & (d <= 1))
                return true;

            return false;
        }

        //Auto generated
        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   s_val == fraction.s_val;
        }

        //Auto generated
        public override int GetHashCode()
        {
            return 1559236110 + s_val.GetHashCode();
        }


        /// <summary>
        /// Создает объект Fraction из заданного значения типа double.
        /// </summary>
        /// <param name="d">Значение, которое будет скопировано в новый объект.</param>
        /// <exception cref="ArgumentException">Переданное значение не находилось в интервале [0 ; 1]</exception>
        public Fraction(double d)
        {
            if (Validate(d))
                s_val = d;
            else
                throw new ArgumentException("Value should be in interval [0 ; 1]");
        }

        /// <summary>
        /// Создает объект Fraction из заданного значения типа float.
        /// </summary>
        /// <param name="f">Значение, которое будет скопировано в новый объект.</param>
        /// <exception cref="ArgumentException">Переданное значение не находилось в интервале [0 ; 1]</exception>
        public Fraction(float f) : this((double)f) { }

        /// <summary>
        /// Создает объект Fraction из заданного значения типа int.
        /// </summary>
        /// <param name="d">Значение, которое будет скопировано в новый объект.</param>
        /// <exception cref="ArgumentException">Переданное значение не было 0 или 1.</exception>
        public Fraction(int i) : this((double)i) { }
    }
}
