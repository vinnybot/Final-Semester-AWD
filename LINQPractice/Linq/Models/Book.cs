using System;
using System.Collections.Generic;

namespace Linq.Models;

public partial class Book
{
    public string BookCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? PublisherCode { get; set; }

    public string? Type { get; set; }

    public decimal? Price { get; set; }

    public string? Paperback { get; set; }
}
