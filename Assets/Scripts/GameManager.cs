using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Unity.VisualScripting;
using UnityEngine.Video;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

public class GameManager : MonoBehaviour
{
    /* PUBLIC */
    // get the public assets attached to the game object
    public TextAsset defaultLayout;
    // create a new game state
    public Dictionary<string, Square> gameState= new ();
    // Dictionary to list all game pieces
    public Dictionary<string, ChessPiece> chessPieces = new();

    /* PRIVATE */
    // Get the snapGrid attached to the game object
    SnapGrid snapGrid;
    // Name of all pieces in use
    string[] pieceNames = new string[] {
        "Bishop White",
        "Bishop White 2",
        "King White",
        "Knight White",
        "Knight White 2",
        "Queen White",
        "Rook White",
        "Rook White 2",
        "Pawn White",
        "Pawn White 2",
        "Pawn White 3",
        "Pawn White 4",
        "Pawn White 5",
        "Pawn White 6",
        "Pawn White 7",
        "Pawn White 8",
        "Bishop Black",
        "Bishop Black 2",
        "King Black",
        "Knight Black",
        "Knight Black 2",
        "Queen Black",
        "Rook Black",
        "Rook Black 2",
        "Pawn Black",
        "Pawn Black 2",
        "Pawn Black 3",
        "Pawn Black 4",
        "Pawn Black 5",
        "Pawn Black 6",
        "Pawn Black 7",
        "Pawn Black 8",
    };
    // Positional array showing which piece is on that square
    bool[,] occupied = new bool[10,10];
    // Setup visitor
    MySANVisitor visitor = new MySANVisitor();
    // The game read
    ReadGame game;
    // The current player
    string currentPlayer = "White";


    /* GAME LOOP */
    // Attach everything to their reference
    void Awake()
    {
        snapGrid = GetComponent<SnapGrid>();
        game = GetComponent<ReadGame>();
        ChessPiece piece;
        

        // add the pieces to the managed list
        foreach (string pieceName in pieceNames)
        {
            if (pieceName.Contains("King"))
            {
                piece = new King(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }
            if (pieceName.Contains("Queen"))
            {
                piece = new Queen(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }
            if (pieceName.Contains("Bishop"))
            {

                piece = new Bishop(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }
            if (pieceName.Contains("Knight"))
            {
                piece = new Knight(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }
            if (pieceName.Contains("Rook"))
            {
                piece = new Rook(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }
            if (pieceName.Contains("Pawn"))
            {
                piece = new Pawn(pieceName, GameObject.Find(pieceName));
                chessPieces.Add(pieceName, piece);
            }

        }

        SetupLayout();
    }

    // Start the game
    private void Start()
    {
        ReadMoves();

        // Update move list
        foreach (var piece in chessPieces.Values)
        {
            piece.GenerateMoves();

            foreach (var position in piece.possibleMove)
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (position.rank == 1 && position.file == j)
                        {
                            snapGrid.snapArray[i, j].GetComponent<MoveColor>().Green();
                        } 
                    }
                }
            }
        }


        //ExecuteFirstMove();
    }

    // Update is called once per frame
    void Update()
    {    

    }

    /* METHODS */

    // Switch player
    void NextPlayer()
    {
        if (currentPlayer == "White") { currentPlayer= "Black"; }
        else currentPlayer= "White";
    }

    // Read the moves provided by ReadGame
    void ReadMoves()
    {
        SANLexer lexer;
        SANParser parser;

        foreach (var game in game.gameList)
        {
            foreach (var move in game)
            {
                // Read the move into the move list
                lexer = new SANLexer(new AntlrInputStream(move));
                parser = new SANParser(new CommonTokenStream(lexer));
                visitor.Visit(parser.san_game());
            }
        }

        Debug.Log("GAME END");
    }

    // Setup the ogirinal layout (reset game)
    void SetupLayout()
    {
        Dictionary<string, int> column = new();
        column.Add("A", 1);
        column.Add("B", 2);
        column.Add("C", 3);
        column.Add("D", 4);
        column.Add("E", 5);
        column.Add("F", 6);
        column.Add("G", 7);
        column.Add("H", 8);
        string[] lines = defaultLayout.text.Split("\n");
        string[] lineData;
        ChessPiece piece = null;
        int x = 0;
        int y = 0;

        foreach (var line in lines)
        {
            if (line.Length == 0) continue;

            lineData = line.Split(",");
            piece = chessPieces[lineData[0]];
            x = column[lineData[1]];
            y = int.Parse(lineData[2]);
            Square square = new Square(x,y);

            piece.square= square;

            gameState.Add(lineData[0] , square);
            piece.gameObject.transform.position = snapGrid.snapArray[x, y].transform.position;
            occupied[x, y] = true;
        }

    }

    void UpdatePossibleMoveList()
    {

    }
    // Move the specified piece to the correct square
    public void MovePiece(string name, int toFile, int toRank)
    {
        // make space available
        occupied[gameState[name].rank, gameState[name].file] = false;
        // update gamestate
        gameState[name].UpdateSquare(toFile, toRank);
        // actual movement
        chessPieces[name].gameObject.transform.position= snapGrid.snapArray[toFile, toRank].transform.position;
        // make space unavailable
        occupied[toFile, toRank] = true;
    }

    // Execute the first move of the game
    void ExecuteFirstMove()
    {
        List<Move> moves = visitor.games[0];
        Move firstMove = moves[0];
        // Round up all pieces of this type
        List<string> pieces = GetPieces(firstMove.piece);
        string chosenPiece ="";
        // figure out which piece is this?
        // Is its list of possible moves contains the toSquare?

    }
    List<string> GetPieces(char kind)
    {

        List<string> pieces = new List<string>();
        switch(kind)
        {
            case 'P':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("Pawn") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
            case 'K':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("King") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
            case 'Q':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("Queen") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
            case 'B':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("Bishop") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
            case 'N':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("Knight") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
            case 'R':
                { 
                    foreach (var piece in chessPieces.Keys)
                    {
                        if (piece.Contains("Rook") && piece.Contains(currentPlayer)) pieces.Add(piece);
                    }
                }
                break;
        }
        return pieces;
    }

}
