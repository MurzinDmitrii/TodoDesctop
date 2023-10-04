using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.Models;

public class Todo
{
    public string Description { get; set; } = null!;

    public bool? Check { get; set; }
}
