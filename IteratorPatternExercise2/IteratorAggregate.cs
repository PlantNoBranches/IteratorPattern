using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternReverse
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}