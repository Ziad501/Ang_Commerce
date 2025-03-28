using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eStoreApi.Models
{
    [Table("products", Schema = "estore")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(45)]
        public string? ProductName { get; set; }

        [MaxLength(100)]
        public string? ProductDescription { get; set; }

        public decimal? Price { get; set; }

        public int? Ratings { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [MaxLength(45)]
        public string? ProductImg { get; set; }
    }
}
