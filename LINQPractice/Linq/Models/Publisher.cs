﻿using System;
using System.Collections.Generic;

namespace Linq.Models;

public partial class Publisher
{
    public string PublisherCode { get; set; } = null!;

    public string? PublisherName { get; set; }

    public string? City { get; set; }
}
