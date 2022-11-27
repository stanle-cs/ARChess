using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    public Rook(string name, GameObject gameObject) : base(name, gameObject)
    {
        this.kind = PieceType.ROOK;
    }
    override public void GenerateMoves()
    {
        possibleMove.Clear();
        if (owner == "White") possibleMove.Add(new Square(square.rank, square.file + 1));
        else possibleMove.Add(new Square(square.rank, square.file - 1));
    }
}
