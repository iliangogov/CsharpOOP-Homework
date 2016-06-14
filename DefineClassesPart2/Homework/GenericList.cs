namespace Homework
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class GenericList<T> : IEnumerable          //task 5
    {
        private T[] array;
        private int index;

        public GenericList()
        {
            this.array = new T[3];
            this.index = 0;
        }

        public void Add(T element)
        {
            this.array[this.index] = element;
            index++;

            if (this.index == array.Length)
            {
                Array.Resize(ref this.array, array.Length * 2);  //task 6
                this.array[this.index] = element;
            }
        }

        public T Access(int position)
        {
            return array[position];
        }

        public T[] RemoveAt(int position)
        {
            T[] temp = new T[this.array.Length - 1];
            if (position > 0)
            {
                Array.Copy(this.array, 0, temp, 0, position);
            }
            if (position < this.array.Length - 1)
            {
                Array.Copy(this.array, position + 1, temp, position, this.array.Length - position - 1);
            }
            this.array = new T[temp.Length];
            Array.Copy(temp, this.array, temp.Length);
            return this.array;
        }

        public T[] InsertAt(T toInsert, int position)
        {
            T[] temp = new T[this.array.Length + 1];

            if (position > 0)
            {
                Array.Copy(this.array, 0, temp, 0, position);
            }

            temp[position] = toInsert;

            if (position < this.array.Length)
            {
                Array.Copy(this.array, position, temp, position + 1, this.array.Length - position);
            }

            this.array = new T[temp.Length];
            Array.Copy(temp, this.array, temp.Length);
            return this.array;

        }

        public string FindByValue(T element)
        {
            string indexes = String.Empty;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(element))
                {
                    indexes += i + ",";

                }

            }
            if (String.IsNullOrEmpty(indexes))
            {
                indexes = "No Matches";
            }

            return string.Format("This element:{0} is on position:{1} ", element, indexes.TrimEnd(','));

        }

        public T[] Clear()
        {
            this.array = new T[this.array.Length];
            return this.array;
        }

        public IEnumerator GetEnumerator()
        {
            var newEnumerator = this.array.GetEnumerator();
            return newEnumerator;
        }

        public T Min()
        {
            var min = this.array[0];
            for (int i = 0; i < this.index; i++)
            {
                var compare = Comparer<T>.Default.Compare(min, this.array[i]);

                if (compare == 1)
                {
                    min = this.array[i];
                }
            }
            return min;
        }

        public T Max()
        {
            var max = this.array[0];

            for (int i = 0; i < this.index; i++)
            {

                var compare = Comparer<T>.Default.Compare(max, this.array[i]);

                if (compare == -1)
                {
                    max = this.array[i];
                }

            }

            return max;
        }


    }

}
