using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ReadGame : MonoBehaviour
{
    public TextAsset input;
    public List<List<string>> gameList;

    private void Awake()
    {
        ReadMove(input);
    }

    void ReadMove(TextAsset input)
    {
        PGNLexer lexer = new PGNLexer(new AntlrInputStream(input.text));
        PGNParser parser = new PGNParser(new CommonTokenStream(lexer));
        var visitor = new MyPGNVisitor();
        visitor.Visit(parser.parse());
        gameList = visitor.gameList;
        foreach (var game in gameList)
        {
            //create a new line
            string output = "";
            int c = 0;
            foreach (var item in game)
            {
                output += " " + item.ToString();
                c++;
            }
            print(output + " total move: " + c);
        }
    }
}
