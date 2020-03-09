using System;
namespace asp_net_core_book_api.Models
{
    // intermediary class for many-to-many relationship.
    public class BookCategory
    {
        public BookCategory()
        {
        }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
