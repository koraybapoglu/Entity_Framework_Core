﻿using System;
using System.Collections.Generic;

namespace Entity_DatabaseFirst.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
