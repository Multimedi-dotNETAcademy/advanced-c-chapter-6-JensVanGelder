using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Book
{
    public partial class FormBook : Form
    {
        private List<Book> books = new List<Book>();
        private CoffeeTableBook b1 = new CoffeeTableBook() { ISBN = 786589, Title = "Koffie Bingo", Author = "Seba", Price = 40 };
        private TextBook b2 = new TextBook() { ISBN = 656565, Title = "Hoe maak ik een koffie", Author = "Michiel", Price = 60 };

        public FormBook()
        {
            InitializeComponent();
            books.Add(new Book() { ISBN = 123456, Title = "Samson & Gert: Ik moest kloppen", Author = "Studio 100", Price = 35 });
            books.Add(new CoffeeTableBook() { ISBN = 321654, Title = "Samson & Gert: Alles is Op", Author = "Studio 100", Price = 50 });
            books.Add(new TextBook() { ISBN = 111111, Title = "Vliegtuigjes Maken 101", Author = "De Burgemeester", Price = 70 });
            books.Add(new TextBook() { ISBN = 111112, Title = "Test: Invalid Price For TextBook", Author = "JVG", Price = 10 });
            books.Add(new CoffeeTableBook() { ISBN = 111115, Title = "Test: Invalid Price For CoffeeTableBook", Author = "JVG", Price = 200 });
            books.Add(b1);
            books.Add(b2);
            books.Add(TelOp(b1, b2));
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            foreach (Book book in books)
            {
                listBook.Items.Add(book);
                comboBook1.Items.Add(book);
                comboBook2.Items.Add(book);
            }
        }

        private static Book TelOp(Book book1, Book book2)
        {
            Book omnibus = new Book();
            {
                omnibus.Title = $"Omnibus van [{book1.Author},{book2.Author}]";
                omnibus.Price = (book1.Price + book2.Price) / 2;
            }
            return omnibus;
        }

        private void comboBook1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompareBooks();
        }

        private void comboBook2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompareBooks();
        }

        private void CompareBooks()
        {
            if (comboBook1.SelectedItem.Equals(comboBook2.SelectedItem))
            {
                label1.Text = "=";
            }
            else
            {
                label1.Text = "=/=";
            }
        }
    }
}