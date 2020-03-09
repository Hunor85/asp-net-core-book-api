using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_book_api.Models
{
    public class Author
    {
        public Author()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "First Name cannot be more than 100 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Last Name cannot be more than 200 characters")]
        public string LastName { get; set; }

        // navigational property for 1-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual Country Country { get; set; }


        // collection navigation property for many-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
