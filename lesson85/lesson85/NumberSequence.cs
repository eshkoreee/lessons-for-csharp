using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lesson85
{
    public class NumberSequence : IEnumerable<int>
    {
        private readonly int _start;
        private readonly int _count;

        public NumberSequence(int start, int count)
        {
            _start = start;
            _count = count;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _start + i;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Внутренний класс-перечислитель
        private class NumberEnumerator : IEnumerator<int>
        {
            private readonly int _start;
            private readonly int  _count;
            private int _index = -1; // -1 означает "до начала"

            public NumberEnumerator(int start, int count)
            {
                _start = start;
                _count = count;
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _count;
            }

            public int Current
            {
                get
                {
                    if (_index < 0 || _index >= _count)
                        throw new InvalidOperationException("Invalid position");
                    return _start + _index;
                }
            }

            object System.Collections.IEnumerator.Current => Current;

            public void Reset()
            {
                _index = -1;
            }

            public void Dispose()
            {
                
            }
        }
    }
}
