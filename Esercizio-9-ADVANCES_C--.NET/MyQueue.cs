using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_9_ADVANCES_C__.NET
{
    internal class MyQueue<T> : IQueue<T>
    {
        private Queue<T> queue;
        private ILogger logger;

        public MyQueue()
        {
        }

        public MyQueue(ILogger logger)
        {
            queue = new Queue<T>();
            this.logger = logger;
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
                new StackOverflowException();

            T item = queue.Dequeue();
            logger.Log("Elemento " + item.ToString() + " rimosso dalla coda.");
            return item;
        }

        public void Enqueue(T item)
        {
            if (queue.Count == 0)
                new StackOverflowException();
            queue.Enqueue(item);
            logger.Log("Elemento " + item.ToString() + " aggiunto alla coda.");
        }

        public T Peek()
        {
            if (queue.Count == 0)
                new StackOverflowException();
         
            T item = queue.Peek();
            logger.Log("Elemento in testa alla coda: " + item.ToString());
            return item;
        }
    }
}
