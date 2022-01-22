using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Model
{
    public class AuthorDetails
    {
        // 1:1
        public int Id { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}