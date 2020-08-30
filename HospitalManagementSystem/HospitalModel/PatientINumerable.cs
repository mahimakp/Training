using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HospitalModel
{
   
    public class Patients : IEnumerable
    {
        private Patient[] _patients;
        public Patients(Patient[] pArray)
        {
            _patients = new Patient[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _patients[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PatientsEnum GetEnumerator()
        {
            return new PatientsEnum(_patients);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PatientsEnum : IEnumerator
    {
        public Patient[] _patients;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PatientsEnum(Patient[] list)
        {
            _patients = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _patients.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Patient Current
        {
            get
            {
                try
                {
                    return _patients[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    

    /* This code produces output similar to the following:
     *
     * John Smith
     * Jim Johnson
     * Sue Rabon
     *
     */
}
