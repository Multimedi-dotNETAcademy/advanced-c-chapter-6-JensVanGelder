using System;

namespace Book
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private double _price;

        public virtual double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }

        public override bool Equals(Object obj)
        {
            var book = obj as Book;

            if (book == null)
            {
                return false;
            }

            return this.ISBN.Equals(book.ISBN);
        }
    }
}