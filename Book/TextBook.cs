namespace Book
{
    internal class TextBook : Book
    {
        public int GradeLevel { get; set; }

        public override double Price
        {
            get => base.Price;
            set
            {
                if ((value > 20) && (value < 80))
                {
                    base.Price = value;
                }
            }
        }
    }
}