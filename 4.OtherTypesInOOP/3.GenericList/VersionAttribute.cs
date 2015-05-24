using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | 
                    AttributeTargets.Class | 
                    AttributeTargets.Interface,
                    AllowMultiple = true)]
    class VersionAttribute : System.Attribute
    {
        public int major;
        public int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Minor = minor;
            this.Major = major;
        }
        public int Major
        {
            get
            {
                return this.major;
            }
            set
            {
                this.major = value;
            }
        }
        public int Minor
        {
            get
            {
                return this.minor;
            }
            set
            {
                this.minor = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}.{1}", this.major, this.minor);
        }

    }
}
