using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1; // now works the set
            Console.WriteLine(product.Id); // now works the get
        }
    }
    class Product
    {
        //get works when on read, set works when on write

        //field
        decimal _unitPrice;

        //auto implemented property
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitInPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value + _unitPrice * 18 / 100; } // show the price with tax
        }
        public decimal UnitInStock { get; set; }

        //"prop", the classic property but if you want to use extensive property, write "propfull"
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
