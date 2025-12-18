using System.Diagnostics.Contracts;

namespace OrderTracker.Model
{
    public class Product_Prop
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public double Price { get; set; }
        public string Value { get; set; }

    }
}
