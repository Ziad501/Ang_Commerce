using System;
using System.Collections.Generic;

namespace eStoreApi.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public decimal? Price { get; set; }

    public int? Ratings { get; set; }

    public int? CategoryId { get; set; }

    public string? ProductImg { get; set; }

    public virtual Category? Category { get; set; }
}
