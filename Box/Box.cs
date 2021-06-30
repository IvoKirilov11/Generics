﻿using System.Collections.Generic;


namespace BoxOfT
{
    public class Box<T>
    {
        List<T> elements;

        public Box()
        {
            elements = new List<T>();
        }

        public void Add(T element)
        {
            elements.Insert(0, element);
        }
        public T Remove()
        {
            T removeElemet = elements[0];
            elements.RemoveAt(0);
            return removeElemet;
        }

        public int Count { get { return elements.Count; } }

    }
}
