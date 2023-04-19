using System;
using System.Collections.Generic;

namespace Linq.Models;

public partial class Inventory
{
    public string BookCode { get; set; } = null!;

    public decimal BranchNum { get; set; }

    public decimal? OnHand { get; set; }
}
