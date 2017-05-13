using System.Collections.Generic;

namespace Generics
{
    public class MagicHat<T>
    {
        private readonly Queue<T> _queue = new Queue<T>();

        public void Add(T magicalObject)
        {
            if (magicalObject != null)
            {
                _queue.Enqueue(magicalObject);
            }
        }

        public T Retrieve()
        {
            return _queue.Dequeue();
        }

    }

}



