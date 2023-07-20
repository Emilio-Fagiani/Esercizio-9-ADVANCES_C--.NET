using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_9_ADVANCES_C__.NET
{
    internal interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
