using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPice
{

    public override int GetIndex()
    {
        return 2;
    }

    public override string GetName()
    {
        return "Bishop";
    }

    public override string GetInfo()
    {
        return "Bishop moves and strikes in all directions diagonally on any number of cells.";
    }
}
