using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_book_api.Models
{
    public class Reviewer
    {
        public Reviewer()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "First Name must be up to 100 characters in length")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Last Name must be up to 200 characters in length")]
        public string LastName { get; set; }

        // navigational property for 1-to-many relationship
        // virtual => lazy loading in EF core. Tree of classes are available to us so we can take what we need.
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
