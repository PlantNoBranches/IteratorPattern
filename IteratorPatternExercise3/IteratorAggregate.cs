using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternMerged
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}