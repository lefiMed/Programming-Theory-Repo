using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPice
{
    public override int GetIndex()
    {
        return 0;
    }

    public override string GetName()
    {
        return "King";
    }

    public override string GetInfo()
    {
        return "King moves and hits vertically, horizontally and diagonally , but only one square in any direction";
    }
}
