using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
{
    bool doubleMove;
    public Pawn(string name, GameObject gameObject) : base(name, gameObject)
    {
        this.kind = PieceType.PAWN;
        this.doubleMove = true;
    }
    override public void GenerateMoves()
    {
        possibleMove.Clear();
        int amountMove = 0;
        if (this.doubleMove) amountMove = 2;
        else amountMove = 1;
        for (int i = 1; i <= amountMove; i++)
        {
            if (owner == "White") possibleMove.Add(new Square(square.rank, square.file + i));
            else possibleMove.Add(new Square(square.rank, square.file - i));
        }
    }
    override public void Move(int toRank, int toFile) 
    {
        this.square.rank = toRank;
        this.square.file = toFile;
        this.doubleMove = false;

        GenerateMoves();
    }
}
