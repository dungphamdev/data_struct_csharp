using System;
using System.Collections.Generic;
using System.Text;

namespace data_struct.ADT
{
    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> next = null;
    }
}
