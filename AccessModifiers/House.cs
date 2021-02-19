using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class House
    {
        

        public House()
        {

        }
        public int Id { get; set; }
        public string City { get; set; }
        protected string Suburb { get; set; }

        //private, internal, public, protected
        //private is only valid on where is it stay, just only works in its class
        //internal is only valid on the same namespace
        //internal is the default only when write classes, so both are same (internal class Customer) = (class Customer), internal works only on same namepsace
        //public is valid on everywhere if due reference
        //protected is valid on where is it stay as private, also it is valid if due inherited
    }

    public class HouseTest : House
    {
        public HouseTest()
        {
            
        }
    }
}
