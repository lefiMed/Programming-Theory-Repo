using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kasle : ChessPice
{

    public override int GetIndex()
    {
        return 4;
    }

    public override string GetName()
    {
        return "Kasle";
    }

    public override string GetInfo()
    {
        return "Castle moves and hits vertically and horizontally on any number of cells";
    }
}
