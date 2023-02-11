namespace _03_Combo_box
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacture { get; set; }

        public override string ToString()
        {
            return $"{Name} by {Manufacture}";
        }
    }
}