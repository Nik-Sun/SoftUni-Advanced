using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingQueue
{
    class QueueElement<T>
    {
        public QueueElement<T> Next { get; set; }
        public T Value { get; set; }

    }
}
