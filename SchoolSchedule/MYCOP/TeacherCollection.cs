using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SchoolSchedule.src;
using SchoolSchedule.Teachers;

namespace SchoolSchedule.Мусор
{

    public class TeacherCollection : ICollection<Teacher>
    {

        private readonly List<Teacher> innerCollection;
        public int Count
        {
            get
            {
                return innerCollection.Count;
            }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public TeacherCollection()
        {
            innerCollection = new List<Teacher>();
        }
        public Teacher this[int index]
        {
            get { return innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public IEnumerator<Teacher> GetEnumerator()
        {
            return new TeacherEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TeacherEnumerator(this);
        }

        public void AddRange(List<Teacher> teachers)
        {
            innerCollection.AddRange(teachers);
        }
        public void Add(Teacher item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
        }
        public bool Remove(Teacher item)
        {
            bool result = false;

            // Iterate the inner collection to
            // find the box to be removed.
            for (int i = 0; i < innerCollection.Count; i++)
            {
                Teacher curBox = innerCollection[i];

                if (curBox.Equals(item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
        public void Clear()
        {
            innerCollection.Clear();
        }
        public bool Contains(Teacher item)
        {
            bool found = false;

            foreach (Teacher bx in innerCollection)
            {
                // Equality defined by the Teacher
                // class's implmentation of IEquatable<T>.
                if (bx.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }
        public void CopyTo(Teacher[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < innerCollection.Count; i++)
            {
                array[i + arrayIndex] = innerCollection[i];
            }
        }
    }
}
