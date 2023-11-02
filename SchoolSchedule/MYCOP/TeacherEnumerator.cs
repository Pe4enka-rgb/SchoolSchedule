using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SchoolSchedule.Teachers;

namespace SchoolSchedule.Мусор
{
    public class TeacherEnumerator : IEnumerator<Teacher>
    {

        private TeacherCollection _collection;
        private int currentIndex;
        private Teacher currentTeacher;

        public TeacherEnumerator(TeacherCollection collection)
        {
            _collection = collection;
            currentIndex = -1;
            currentTeacher = default;
        }
        public bool MoveNext()
        {
            //Avoids going beyond the end of the collection.
            if (++currentIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                currentTeacher = _collection[currentIndex];
            }
            return true;
        }
        public void Reset() { currentIndex = -1; }
        void IDisposable.Dispose() { }
        public Teacher Current
        {
            get { return currentTeacher; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
