using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public class NameRepository : IContainer
    {
        public static string[] names = { "Robert", "Karan","Sagar","Bhavesh" };
        public IIterator getIterator()
        {
            return new NameIterator();

        }



        public class NameIterator : IIterator
        {

            int index;

            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
