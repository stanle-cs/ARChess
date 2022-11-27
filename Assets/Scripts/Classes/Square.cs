using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square
{
    public int rank = 0;
    public int file = 0;
    
    public Square(int rank, int file)
    {
        this.rank = rank;
        this.file = file;
    }
    public void UpdateSquare(int toFile, int toRank)
    {
        file = toFile;
        rank = toRank;
    }

    public void SetRankChar(char charRank)
    {
        rank = RankToInt(charRank);
    }

    public char GetRankChar()
    {
        return IntToRank(rank);
    }
    public static int RankToInt(char charRank)
    {
        return (int) (charRank - 96);
    }

    public static char IntToRank(int intRank) 
    {
        char output = Convert.ToChar(intRank + 96);
        return output;

    }
}

