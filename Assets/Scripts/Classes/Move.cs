using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move
{
    public char piece;
    public char fromRank;
    public int fromFile = 0;
    public char toRank;
    public int toFile = 0;
    public bool capture = false;
    public bool castle_king = false;
    public bool castle_queen = false;
    public bool promote = false;
    public bool A1 = false;
    public bool A2 = false;
    public bool A3 = false;
    public char promoteTo;
}
