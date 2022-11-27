using Antlr4.Runtime.Misc;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MySANVisitor: SANBaseVisitor<string>
{
    public List<List<Move>> games = new();
    public List<Move> moves = new();

    public override string VisitSan_move([NotNull] SANParser.San_moveContext context)
    {
        return base.VisitSan_move(context);
    }
    public override string VisitSan_termination([NotNull] SANParser.San_terminationContext context)
    {
        games.Add(moves);
        moves = new();
        return base.VisitSan_termination(context);
    }
    public override string VisitPiece_moves([NotNull] SANParser.Piece_movesContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.piece = input[0];
        move.toRank = input[1];
        move.toFile= int.Parse(input[2].ToString());
        Debug.Log(move.piece + " PIECE MOVE TO " + move.toRank + move.toFile);

        return base.VisitPiece_moves(context);
    }

    public override string VisitPiece_moves_A1([NotNull] SANParser.Piece_moves_A1Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A1 = true;
        move.piece = input[0];
        move.fromRank = input[1];
        move.toRank= input[2];
        move.toFile= int.Parse(input[3].ToString());
        Debug.Log(move.piece + " AMBIGUOUS PIECE MOVE FROM FILE " + move.fromRank + " TO " + move.toRank + move.toFile);

        return base.VisitPiece_moves_A1(context);
    }

    public override string VisitPiece_moves_A2([NotNull] SANParser.Piece_moves_A2Context context)
    {   
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A2 = true;
        move.piece = input[0];
        move.fromFile = int.Parse(input[1].ToString());
        move.toRank= input[2];
        move.toFile= int.Parse(input[3].ToString());
        Debug.Log(move.piece + " AMBIGUOUS PIECE MOVE FROM RANK " + move.fromFile + " TO " + move.toRank + move.toFile);

        return base.VisitPiece_moves_A2(context);
    }

    public override string VisitPiece_moves_A3([NotNull] SANParser.Piece_moves_A3Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A3 = true;
        move.piece = input[0];
        move.fromRank = input[1];
        move.fromFile = int.Parse(input[2].ToString());
        move.toRank= input[3];
        move.toFile= int.Parse(input[4].ToString());
        Debug.Log(move.piece + " AMBIGUOUS PIECE MOVE FROM SQUARE " + move.fromRank + move.fromFile + " TO " + move.toRank + move.toFile);

        return base.VisitPiece_moves_A3(context);
    }

    public override string VisitPiece_move_capture([NotNull] SANParser.Piece_move_captureContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.piece = input[0];
        move.capture = true;
        move.toRank = input[2];
        move.toFile= int.Parse(input[3].ToString());
        Debug.Log(move.piece + " PIECE CAPTURE " + move.toRank + move.toFile);

        return base.VisitPiece_move_capture(context);
    }

    public override string VisitPiece_move_capture_A1([NotNull] SANParser.Piece_move_capture_A1Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A1 = true;
        move.piece = input[0];
        move.fromRank= input[1];
        move.capture = true;
        move.toRank = input[3];
        move.toFile= int.Parse(input[4].ToString());
        Debug.Log(move.piece + " A1 PIECE CAPTURE " + move.toRank + move.toFile);

        return base.VisitPiece_move_capture_A1(context);
    }

    public override string VisitPiece_move_capture_A2([NotNull] SANParser.Piece_move_capture_A2Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A2 = true;
        move.piece = input[0];
        move.fromFile= int.Parse(input[1].ToString());
        move.capture = true;
        move.toRank = input[3];
        move.toFile= int.Parse(input[4].ToString());
        Debug.Log(move.piece + " A2 PIECE CAPTURE " + move.toRank + move.toFile);

        return base.VisitPiece_move_capture_A2(context);
    }

    public override string VisitPiece_move_capture_A3([NotNull] SANParser.Piece_move_capture_A3Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.A3 = true;
        move.piece = input[0];
        move.fromRank= input[1];
        move.fromFile= int.Parse(input[2].ToString());
        move.capture = true;
        move.toRank = input[4];
        move.toFile= int.Parse(input[5].ToString());
        Debug.Log(move.piece + " A3 PIECE CAPTURE " + move.toRank + move.toFile);

        return base.VisitPiece_move_capture_A3(context);
    }

    public override string VisitPawn_push([NotNull] SANParser.Pawn_pushContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.piece = 'P';
        move.toRank = input[0];
        move.toFile= int.Parse(input[1].ToString());
        Debug.Log(move.piece + " PAWN PUSH TO " + move.toRank + move.toFile);

        return base.VisitPawn_push(context);
    }

    public override string VisitPawn_push_promote([NotNull] SANParser.Pawn_push_promoteContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.piece = 'P';
        move.toRank = input[0];
        move.toFile= int.Parse(input[1].ToString());
        move.promote = true;
        move.promoteTo = input[3];
        Debug.Log(move.piece + " PAWN PUSH TO " + move.toRank + move.toFile + " PROMOTE TO " + move.promoteTo);

        return base.VisitPawn_push_promote(context);
    }

    public override string VisitPawn_capture([NotNull] SANParser.Pawn_captureContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.piece = 'P';
        move.fromRank= input[0];
        move.toRank = input[2];
        move.toFile= int.Parse(input[3].ToString());
        Debug.Log(move.piece + " PAWN CAPTURE TO " + move.toRank + move.toFile);

        return base.VisitPawn_capture(context);
    }

    public override string VisitPawn_capture_A1([NotNull] SANParser.Pawn_capture_A1Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A3 = true;
        move.piece = 'P';
        move.fromRank= input[0];
        move.fromFile= int.Parse(input[1].ToString());
        move.toRank = input[3];
        move.toFile= int.Parse(input[4].ToString());
        Debug.Log(move.piece + " A1 PAWN CAPTURE TO " + move.toRank + move.toFile);

        return base.VisitPawn_capture_A1(context);
    }

    public override string VisitPawn_capture_promote([NotNull] SANParser.Pawn_capture_promoteContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();
        
        move.piece = 'P';
        move.fromRank = input[0];
        move.toRank= input[2];
        move.toFile= int.Parse(input[3].ToString());
        move.promote = true;
        move.promoteTo = input[5];
        Debug.Log(move.piece + " PAWN CAPTURE TO " + move.toRank + move.toFile + " PROMOTE TO " + move.promoteTo);

        return base.VisitPawn_capture_promote(context);
    }

    public override string VisitPawn_capture_promote_A1([NotNull] SANParser.Pawn_capture_promote_A1Context context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.A3 = true;
        move.piece = 'P';
        move.fromRank= input[0];
        move.fromFile= int.Parse(input[1].ToString());
        move.toRank = input[3];
        move.toFile= int.Parse(input[4].ToString());
        move.promote = true;
        move.promoteTo = input[6];
        Debug.Log(move.piece + " A1 PAWN CAPTURE TO " + move.toRank + move.toFile + " PROMOTE TO " + move.promoteTo);

        return base.VisitPawn_capture_promote_A1(context);
    }

    public override string VisitCastle_king([NotNull] SANParser.Castle_kingContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.piece = 'K';
        move.castle_king = true;
        Debug.Log(move.piece + " CASTLE TO KING SIDE");

        return base.VisitCastle_king(context);
    }

    public override string VisitCastle_queen([NotNull] SANParser.Castle_queenContext context)
    {
        Move move = new();
        moves.Add(move);
        string input = context.GetText();

        move.piece = 'K';
        move.castle_queen = true;
        Debug.Log(move.piece + " CASTLE TO QUEEN SIDE");

        return base.VisitCastle_queen(context);
    }

}


