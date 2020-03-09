using System;
namespace asp_net_core_book_api.Models
{
    // intermediary class for many-to-many relationship.
    public class BookAuthor
    {
        public BookAuthor()
        {
        }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
