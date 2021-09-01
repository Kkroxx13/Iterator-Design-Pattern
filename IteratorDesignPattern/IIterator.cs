using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public interface IIterator
    {
        public Boolean hasNext();
        public Object next();
    }
}
