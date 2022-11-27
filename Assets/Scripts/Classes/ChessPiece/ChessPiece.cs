using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceType
{
    KING = 0,
    QUEEN,
    BISHOP,
    KNIGHT,
    ROOK,
    PAWN
}
public abstract class ChessPiece
{
    public string name;
    public string owner;
    public GameObject gameObject;
    public Square square;
    //Game object here because we want to snap to grid
    public List<Square> possibleMove = new();
    public bool inGame = true;

    public PieceType kind;

    public ChessPiece(string name, GameObject gameObject)
    {
        this.name = name;
        this.gameObject = gameObject;
        if (name.Contains("White"))
            owner = "White";
        if (name.Contains("Black"))
            owner = "Black";
    }
    public abstract void GenerateMoves();

}
