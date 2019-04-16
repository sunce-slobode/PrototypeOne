using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunceSlobode.Prototype.Connections
{
    public class Connection : ConnectionBase
    {
        public override int Visibility { get; }
        public override bool IsActive { get; set; }

        public override void Update()
        {
            if (IsActive)
                base.Update();
        }

        public Connection(IJoint terminator, IParam target, int visibility = 0, bool active = true, IConnectionFormula formula = null) 
            : base(terminator, target, formula)
        {
            Visibility = visibility;
            IsActive = active;
        }
    }
}
