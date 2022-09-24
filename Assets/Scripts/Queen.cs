using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPice
{
    public override int GetIndex()
    {
        return 1;
    }

    public override string GetName()
    {
        return "Queen";
    }

    public override string GetInfo()
    {
        return "Queen moves in all directions vertically, horizontally and diagonally to any number of board cells.";
    }
}
