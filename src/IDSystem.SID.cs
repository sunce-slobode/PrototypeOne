using System;

namespace SunceSlobode.Prototype
{
    public partial class IDSystem
    {
        private class SID : ID
        {
            private Action<int> p_deleteHandler;

            public SID(int value, IDSystem supervisor, Action<int> deleteHandler) : base(value, supervisor)
            {
                p_deleteHandler = deleteHandler;
            }

            ~SID()
            {
                p_deleteHandler(Value);
            }

        }
    }
}
