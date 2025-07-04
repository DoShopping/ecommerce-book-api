using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entitites
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Author { get; set; }

        [MaxLength(20)]
        public string ISBN { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string CoverImageUrl { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
