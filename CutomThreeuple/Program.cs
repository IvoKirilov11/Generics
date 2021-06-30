﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CutomThreeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ");
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            List<string> townData = firstTupleData.ToList().Skip(3).ToList();
            string town = string.Join(" ", townData);
            Threeuple<string, string,string> firstTuple = new Threeuple<string, string,string>(fullName, firstTupleData[2],town);

            string[] secondTupleData = Console.ReadLine().Split(" ");
            bool drunk = secondTupleData[2] == "drunk" ? true : false;
            Threeuple<string, int,bool> secondTuple = new Threeuple<string, int,bool>(secondTupleData[0], int.Parse(secondTupleData[1]), drunk);

            string[] thirdTupleData = Console.ReadLine().Split(" ");
            Threeuple<string, double,string> thirdTuple = new Threeuple<string, double,string>(thirdTupleData[0], double.Parse(thirdTupleData[1]),thirdTupleData[2]);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
