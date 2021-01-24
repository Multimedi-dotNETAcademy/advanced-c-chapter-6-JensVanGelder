namespace Book
{
    internal class CoffeeTableBook : Book
    {
        public override double Price
        {
            get => base.Price;
            set
            {
                if ((value > 35) && (value < 100))
                {
                    base.Price = value;
                }
            }
        }
    }
}