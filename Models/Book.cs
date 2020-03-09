using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_book_api.Models
{
    public class Book
    {
        public Book()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "ISBN must be between 3 and 10 characters")]
        public string Isbn { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot be more than 200 characters")]
        public string Title { get; set; }

        public DateTime? DatePublished { get; set; }

        // navigational property for 1-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<Review> Reviews { get; set; }

        // collection navigation property for many-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
