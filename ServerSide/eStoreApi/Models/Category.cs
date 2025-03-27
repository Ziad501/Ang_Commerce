using System;
using System.Collections.Generic;

namespace eStoreApi.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Category1 { get; set; }

    public int? ParentCategoryId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
