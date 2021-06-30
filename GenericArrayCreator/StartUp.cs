using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = ArrayCreator.Create(5, "Pesho");

            Console.WriteLine(string.Join(", ",array));
            
        }
    }
}
