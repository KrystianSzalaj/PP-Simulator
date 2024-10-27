using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Animals
{
    // Właściwość required
    public required string Description { get; init; }

    // Właściwość z domyślną wartością
    public uint Size { get; set; } = 3;

    // Właściwość do odczytu Info
    public string Info => $"{Description} <{Size}>";
}
