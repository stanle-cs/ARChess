using Antlr4.Runtime.Misc;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyPGNVisitor: PGNBaseVisitor<string>
{
    public List<List<string>> gameList = new();
    List<string> moveList;

    // States
   
    public override string VisitPgn_game([NotNull] PGNParser.Pgn_gameContext context)
    {
        moveList= new();
        gameList.Add(moveList);
        return base.VisitPgn_game(context);
    }

    /**
     * Handle the move found
     */
    public override string VisitSan_move([NotNull] PGNParser.San_moveContext context)
    {
        moveList.Add(context.GetText());
        return base.VisitSan_move(context);
    }

    public override string VisitGame_termination([NotNull] PGNParser.Game_terminationContext context)
    {
        moveList.Add("____");
        return base.VisitGame_termination(context);
    }
}

