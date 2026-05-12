using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternExample
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}