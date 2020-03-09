using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_book_api.Models
{
    public class Category
    {
        public Category()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Category must be up to 50 characters in length")]
        public string Name { get; set; }


        // collection navigation property for many-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
