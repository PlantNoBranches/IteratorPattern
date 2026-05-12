using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPatternReverse
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}