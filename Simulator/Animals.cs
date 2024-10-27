using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Animals
{
    // Prywatne pole dla właściwości
    private string _description = "Unknown";

    // Właściwość required
    public required string Description
    {
        get => _description;
        init
        {
            // Usuwanie spacji na początku i końcu
            string trimmedValue = value.Trim();

            // Upewnij się, że ma co najmniej 3 znaki
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }
            // Upewnij się, że ma najwyżej 15 znaków
            else if (trimmedValue.Length > 15)
            {
                trimmedValue = trimmedValue.Substring(0, 15);
            }

            // Upewnij się, że ma co najmniej 3 znaki po przycięciu
            if (trimmedValue.Length < 3)
            {
                trimmedValue = trimmedValue.PadRight(3, '#');
            }

            _description = trimmedValue;
        }
    }

    // Właściwość z domyślną wartością
    public uint Size { get; set; } = 3;

    // Właściwość do odczytu Info
    public string Info => $"{Description} <{Size}>";
}
