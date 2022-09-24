using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPice
{
    public override int GetIndex()
    {
        return 5;
    }

    public override string GetName()
    {
        return "Pawn";
    }

    public override string GetInfo()
    {
        return "Pawn , the only figure that moves only forward , can not walk back";
    }

}
