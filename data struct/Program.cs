using data_struct.ADT;
using System;

namespace data_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);

            linkedList.ReadAll();
        }
    }
}
