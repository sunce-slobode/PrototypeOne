using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunceSlobode.Prototype
{
    public class ImmutableParam : BasicParam
    {
        public override object Value { get => base.Value; set { } }

        public ImmutableParam(ParamType type, object value, int visibility = 0) : base(type, value, visibility) { }
        public ImmutableParam(ParamType type, object value, Fraction inaccuracy, int visibility = 0) : base(type, value, inaccuracy, visibility) { }
    }
}
