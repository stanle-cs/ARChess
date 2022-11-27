using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    public King(string name, GameObject gameObject) : base(name, gameObject)
    {
        this.kind = PieceType.KING;
    }
    override public void GenerateMoves()
    {
        possibleMove.Clear();
        if (owner == "White") possibleMove.Add(new Square(square.rank, square.file + 1));
        else possibleMove.Add(new Square(square.rank, square.file - 1));
    }
}
