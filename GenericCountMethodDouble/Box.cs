using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            Type typeValue = Value.GetType();
            string valueTypename = typeValue.FullName;
            return $"{valueTypename}: {Value}";
        }
    }
}
