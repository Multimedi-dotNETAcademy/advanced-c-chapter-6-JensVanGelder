﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bookmark_Manager
{
    public partial class FormBookmarks : Form
    {
        private List<BookMark> bookMark = new List<BookMark>();

        public FormBookmarks()
        {
            InitializeComponent();
            bookMark.Add(new BookMark() { Naam = "Youtube", URL = "https://www.youtube.com/" });
        }

        private void FormBookmark_Load(object sender, EventArgs e)
        {
            UpdateBookmarkList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkHidden.Checked)
            {
                bookMark.Add(new HiddenBookMark() { Naam = txtName.Text, URL = txtURL.Text });
            }
            else
            {
                bookMark.Add(new BookMark() { Naam = txtName.Text, URL = txtURL.Text });
            }

            UpdateBookmarkList();
        }

        private void listBookmarks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bookMark[listBookmarks.SelectedIndex].OpenSite();
        }

        public void UpdateBookmarkList()
        {
            listBookmarks.Items.Clear();
            foreach (BookMark i in bookMark)
            {
                listBookmarks.Items.Add(i.ToString());
            }
        }
    }
}