using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
    class Student : Person, IEnumerable
    {
        public static object[] students =
        {
            new Student (){name = "zl"},
            new Student(){name = "zdh"},
            new Student(){name = "lzb"},
            new Student(){name = "lw"}
        };

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        struct Enumerator : IEnumerator
        {
            private object _Current;
            public object Current => _Current;
            private object[] _localstudents;
            private int _index;
            public Enumerator(Student student)
            {
                _index = 0;
                _localstudents = Student.students;
                _Current = _localstudents[_index];
            }
            public bool MoveNext()
            {
                if (_index >= _localstudents.Length)
                {
                    return false;
                }
                _Current = _localstudents[_index];
                _index++;

                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

