﻿using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.City = "Ankara";

            
        }
    }

    internal class Customer //internal is the default only when write classes, so both are same (internal class Customer) = (class Customer), internal works only on same namepsace
    {

    }
}
