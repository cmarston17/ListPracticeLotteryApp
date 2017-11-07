﻿using System;
using System.Collections.Generic;
namespace ListLotteryPractice
{
    public class Lottery
    {
        private List<int> numbers;
        private Random random;

        public Lottery()
        {
            random = new Random();
            numbers = new List<int>();
        }

        public int Lot()
        {
            int number = random.Next(100) + 1;
            numbers.Add(number);
            return number;
        }

        public string print()
        {
            string s = "";
            numbers.Sort();
            foreach (int i in numbers)
                s += i + " ";
            return s;

        }
    }
}
