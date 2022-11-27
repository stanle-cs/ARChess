using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece
{
    public Bishop(string name, GameObject gameObject) : base(name, gameObject)
    {
        this.kind = PieceType.BISHOP;
    }
    override public void GenerateMoves()
    {
        possibleMove.Clear();
        if (owner == "White") possibleMove.Add(new Square(square.rank, square.file + 1));
        else possibleMove.Add(new Square(square.rank, square.file - 1));
    }
}
