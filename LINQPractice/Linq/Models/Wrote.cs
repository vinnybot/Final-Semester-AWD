using System;
using System.Collections.Generic;

namespace Linq.Models;

public partial class Wrote
{
    public string BookCode { get; set; } = null!;

    public decimal AuthorNum { get; set; }

    public decimal? Sequence { get; set; }
}
