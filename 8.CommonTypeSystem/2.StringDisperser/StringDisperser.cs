using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StringDisperser
{
    class StringDisperser : ICloneable,IComparable<StringDisperser>,IEnumerable
    {
        private string[] inputArray;
        public StringDisperser(params string[] input)
        {
            this.InputArray = input;
        }
        public string[] InputArray
        {
            get
            {
                return this.inputArray;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.inputArray = value;
            }
        }
        public override bool Equals(object param)
        {
            StringDisperser stringDisperser = param as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!Object.Equals(this.inputArray[i], stringDisperser.inputArray[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(var item in inputArray)
            {
                result.AppendLine(item) ;
            }
            return result.ToString();
        }
        public override int GetHashCode()
        {
            return inputArray.GetHashCode();
        }
        public static bool operator ==(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return StringDisperser.Equals(stringDisperser1, stringDisperser2);
        }

        public static bool operator !=(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return !(StringDisperser.Equals(stringDisperser1, stringDisperser2));
        }
        object ICloneable.Clone()  // Implicit interface implementation
        {
            return this.Clone();
        }
        public StringDisperser Clone()
        {
            string[] newInputArray = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                newInputArray[i] = inputArray[i];
            }
            StringDisperser newStringDisperser = new StringDisperser(newInputArray);
            return newStringDisperser;
            
        }
        public int CompareTo(StringDisperser other)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != other.inputArray[i])
                {
                    return inputArray[i].CompareTo(other.inputArray[i]);
                }
            }
            return 0;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            StringDisperser stringDisperser = this;
            for (int i = 0; i < inputArray.Length; i++)
            {
                yield return inputArray[i];
            }
        }
    }
}
