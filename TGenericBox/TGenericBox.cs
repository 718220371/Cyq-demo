using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGenericBox
{
    internal class TGenericBox<T>
    {
        private T value;

        public TGenericBox(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get { return value; }
            set { value = value; }
        }

        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
