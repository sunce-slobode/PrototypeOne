using System.Collections.Generic;

namespace SunceSlobode.Prototype
{
    public abstract class ID
    {
        private IDSystem p_system;
        public int Value { get; }

        public static implicit operator int(ID id) => id.Value;
        public static bool operator ==(ID id1, ID id2) => (id1.Value == id2.Value) & (id1.p_system == id2.p_system);
        public static bool operator !=(ID id1, ID id2) => (id1.p_system != id2.p_system) | (id1.Value != id2.Value);
        
        public ID(int value, IDSystem supervisor)
        {
            Value = value;
            p_system = supervisor;
        }

        //Auto generated
        public override bool Equals(object obj)
        {
            return obj is ID iD &&
                   EqualityComparer<IDSystem>.Default.Equals(p_system, iD.p_system) &&
                   Value == iD.Value;
        }

        //Auto generated
        public override int GetHashCode()
        {
            var hashCode = -350250141;
            hashCode = hashCode * -1521134295 + EqualityComparer<IDSystem>.Default.GetHashCode(p_system);
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            return hashCode;
        }
    }
}
