using System;
using System.Linq;

namespace Stack_1_
{
    class Stack
    {
        private int[] _data;

        public int Count => _size;

        public Stack(int size)
        {
            _size = size;
            _data = new int[size];
        }

        private int _size;
        public int Pop()
        {
            if (this._size == 0)
            {
                throw new InvalidOperationException();
            }          
            var  local = _data[0];
            _data[0] = default(int);
            ReconstructArray();
            return local;
        }

        private void ReconstructArray()
        {
            //лень возиться с массивами для оптимизации
            _data =  _data.Where(x => x != 0).ToArray();
            _size = _data.Length;
        }

        private void ExpandArray()
        {
            _size++;
            var reversArray = _data.Reverse().ToArray();
            var tempArray = new int[_size];
            for (int i = 0; i < tempArray.Length-1; i++)
            {
                tempArray[i] = reversArray[i];
            }

            _data = tempArray.Reverse().ToArray();
        }
        public void Push(int insertValue)
        {
            ExpandArray();
            _data[0] = insertValue;
        }
    }
}