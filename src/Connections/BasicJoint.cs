using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunceSlobode.Prototype.Connections
{
    //Возможно это стоит переработать
    public class BasicJoint : IJoint
    {
        List<IConnection> p_emanating;

        public ID DataNumber { get; }

        public int Count => p_emanating.Count;

        public bool IsReadOnly => false;


        public void Add(IConnection item)
            => p_emanating.Add(item);

        public void Clear()
            => p_emanating.Clear();

        public bool Contains(IConnection item)
            => p_emanating.Contains(item);

        public void CopyTo(IConnection[] array, int arrayIndex)
            => p_emanating.CopyTo(array, arrayIndex);

        public IEnumerator<IConnection> GetEnumerator()
            => p_emanating.GetEnumerator();

        public bool Remove(IConnection item)
            => p_emanating.Remove(item);

        public void Update()
        {
            foreach (IConnection connection in p_emanating)
                connection.Update();
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
