using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eStoreApi.Models
{
    [Table("categories", Schema = "estore")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(45)]
        public string? Name { get; set; }

        public int? ParentCategoryId { get; set; }

        [ForeignKey("ParentCategoryId")]
        public virtual Category? ParentCategory { get; set; }

        public virtual ICollection<Category>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
