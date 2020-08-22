using System;
namespace CSharpTutorial
{
    public class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public int GetPages()
        {
            return this.pages;
        }
    }
}
