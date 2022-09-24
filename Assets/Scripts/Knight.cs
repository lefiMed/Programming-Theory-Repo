using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPice
{

    public override int GetIndex()
    {
        return 3;
    }

    public override string GetName()
    {
        return "Knight";
    }

    public override string GetInfo()
    {
        return "Knight moves along an unusual trajectory , moves 2 cells Forward and one cell to the side.";
    }
}
