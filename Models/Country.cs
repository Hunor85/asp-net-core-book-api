using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_book_api.Models
{
    public class Country
    {
        public Country()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Country must be up to 50 characters in length")]
        public string Name { get; set; }

        // navigational property for 1-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<Author> Authors { get; set; }
    }
}
