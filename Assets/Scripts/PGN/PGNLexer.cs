//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PGN.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
public partial class PGNLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WHITE_WINS=1, BLACK_WINS=2, DRAWN_GAME=3, REST_OF_LINE_COMMENT=4, BRACE_COMMENT=5, 
		ESCAPE=6, SPACES=7, STRING=8, INTEGER=9, PERIOD=10, ASTERISK=11, LEFT_BRACKET=12, 
		RIGHT_BRACKET=13, LEFT_PARENTHESIS=14, RIGHT_PARENTHESIS=15, LEFT_ANGLE_BRACKET=16, 
		RIGHT_ANGLE_BRACKET=17, NUMERIC_ANNOTATION_GLYPH=18, SYMBOL=19, SUFFIX_ANNOTATION=20, 
		UNEXPECTED_CHAR=21;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WHITE_WINS", "BLACK_WINS", "DRAWN_GAME", "REST_OF_LINE_COMMENT", "BRACE_COMMENT", 
		"ESCAPE", "SPACES", "STRING", "INTEGER", "PERIOD", "ASTERISK", "LEFT_BRACKET", 
		"RIGHT_BRACKET", "LEFT_PARENTHESIS", "RIGHT_PARENTHESIS", "LEFT_ANGLE_BRACKET", 
		"RIGHT_ANGLE_BRACKET", "NUMERIC_ANNOTATION_GLYPH", "SYMBOL", "SUFFIX_ANNOTATION", 
		"UNEXPECTED_CHAR"
	};


	public PGNLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PGNLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'1-0'", "'0-1'", "'1/2-1/2'", null, null, null, null, null, null, 
		"'.'", "'*'", "'['", "']'", "'('", "')'", "'<'", "'>'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WHITE_WINS", "BLACK_WINS", "DRAWN_GAME", "REST_OF_LINE_COMMENT", 
		"BRACE_COMMENT", "ESCAPE", "SPACES", "STRING", "INTEGER", "PERIOD", "ASTERISK", 
		"LEFT_BRACKET", "RIGHT_BRACKET", "LEFT_PARENTHESIS", "RIGHT_PARENTHESIS", 
		"LEFT_ANGLE_BRACKET", "RIGHT_ANGLE_BRACKET", "NUMERIC_ANNOTATION_GLYPH", 
		"SYMBOL", "SUFFIX_ANNOTATION", "UNEXPECTED_CHAR"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PGN.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static PGNLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,21,153,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,1,0,1,
		0,1,0,1,0,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,5,3,
		62,8,3,10,3,12,3,65,9,3,1,3,1,3,1,4,1,4,5,4,71,8,4,10,4,12,4,74,9,4,1,
		4,1,4,1,4,1,4,1,5,4,5,81,8,5,11,5,12,5,82,1,5,1,5,5,5,87,8,5,10,5,12,5,
		90,9,5,1,5,1,5,1,6,4,6,95,8,6,11,6,12,6,96,1,6,1,6,1,7,1,7,1,7,1,7,1,7,
		1,7,5,7,107,8,7,10,7,12,7,110,9,7,1,7,1,7,1,8,4,8,115,8,8,11,8,12,8,116,
		1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,
		16,1,16,1,17,1,17,4,17,137,8,17,11,17,12,17,138,1,18,1,18,5,18,143,8,18,
		10,18,12,18,146,9,18,1,19,1,19,3,19,150,8,19,1,20,1,20,0,0,21,1,1,3,2,
		5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,
		16,33,17,35,18,37,19,39,20,41,21,1,0,9,2,0,10,10,13,13,1,0,125,125,2,0,
		10,10,12,13,3,0,9,10,13,13,32,32,2,0,34,34,92,92,1,0,48,57,3,0,48,57,65,
		90,97,122,8,0,35,35,43,43,45,45,48,58,61,61,65,90,95,95,97,122,2,0,33,
		33,63,63,164,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,
		0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,
		1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,
		0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,1,43,
		1,0,0,0,3,47,1,0,0,0,5,51,1,0,0,0,7,59,1,0,0,0,9,68,1,0,0,0,11,80,1,0,
		0,0,13,94,1,0,0,0,15,100,1,0,0,0,17,114,1,0,0,0,19,118,1,0,0,0,21,120,
		1,0,0,0,23,122,1,0,0,0,25,124,1,0,0,0,27,126,1,0,0,0,29,128,1,0,0,0,31,
		130,1,0,0,0,33,132,1,0,0,0,35,134,1,0,0,0,37,140,1,0,0,0,39,147,1,0,0,
		0,41,151,1,0,0,0,43,44,5,49,0,0,44,45,5,45,0,0,45,46,5,48,0,0,46,2,1,0,
		0,0,47,48,5,48,0,0,48,49,5,45,0,0,49,50,5,49,0,0,50,4,1,0,0,0,51,52,5,
		49,0,0,52,53,5,47,0,0,53,54,5,50,0,0,54,55,5,45,0,0,55,56,5,49,0,0,56,
		57,5,47,0,0,57,58,5,50,0,0,58,6,1,0,0,0,59,63,5,59,0,0,60,62,8,0,0,0,61,
		60,1,0,0,0,62,65,1,0,0,0,63,61,1,0,0,0,63,64,1,0,0,0,64,66,1,0,0,0,65,
		63,1,0,0,0,66,67,6,3,0,0,67,8,1,0,0,0,68,72,5,123,0,0,69,71,8,1,0,0,70,
		69,1,0,0,0,71,74,1,0,0,0,72,70,1,0,0,0,72,73,1,0,0,0,73,75,1,0,0,0,74,
		72,1,0,0,0,75,76,5,125,0,0,76,77,1,0,0,0,77,78,6,4,0,0,78,10,1,0,0,0,79,
		81,7,2,0,0,80,79,1,0,0,0,81,82,1,0,0,0,82,80,1,0,0,0,82,83,1,0,0,0,83,
		84,1,0,0,0,84,88,5,37,0,0,85,87,8,0,0,0,86,85,1,0,0,0,87,90,1,0,0,0,88,
		86,1,0,0,0,88,89,1,0,0,0,89,91,1,0,0,0,90,88,1,0,0,0,91,92,6,5,0,0,92,
		12,1,0,0,0,93,95,7,3,0,0,94,93,1,0,0,0,95,96,1,0,0,0,96,94,1,0,0,0,96,
		97,1,0,0,0,97,98,1,0,0,0,98,99,6,6,0,0,99,14,1,0,0,0,100,108,5,34,0,0,
		101,102,5,92,0,0,102,107,5,92,0,0,103,104,5,92,0,0,104,107,5,34,0,0,105,
		107,8,4,0,0,106,101,1,0,0,0,106,103,1,0,0,0,106,105,1,0,0,0,107,110,1,
		0,0,0,108,106,1,0,0,0,108,109,1,0,0,0,109,111,1,0,0,0,110,108,1,0,0,0,
		111,112,5,34,0,0,112,16,1,0,0,0,113,115,7,5,0,0,114,113,1,0,0,0,115,116,
		1,0,0,0,116,114,1,0,0,0,116,117,1,0,0,0,117,18,1,0,0,0,118,119,5,46,0,
		0,119,20,1,0,0,0,120,121,5,42,0,0,121,22,1,0,0,0,122,123,5,91,0,0,123,
		24,1,0,0,0,124,125,5,93,0,0,125,26,1,0,0,0,126,127,5,40,0,0,127,28,1,0,
		0,0,128,129,5,41,0,0,129,30,1,0,0,0,130,131,5,60,0,0,131,32,1,0,0,0,132,
		133,5,62,0,0,133,34,1,0,0,0,134,136,5,36,0,0,135,137,7,5,0,0,136,135,1,
		0,0,0,137,138,1,0,0,0,138,136,1,0,0,0,138,139,1,0,0,0,139,36,1,0,0,0,140,
		144,7,6,0,0,141,143,7,7,0,0,142,141,1,0,0,0,143,146,1,0,0,0,144,142,1,
		0,0,0,144,145,1,0,0,0,145,38,1,0,0,0,146,144,1,0,0,0,147,149,7,8,0,0,148,
		150,7,8,0,0,149,148,1,0,0,0,149,150,1,0,0,0,150,40,1,0,0,0,151,152,9,0,
		0,0,152,42,1,0,0,0,12,0,63,72,82,88,96,106,108,116,138,144,149,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
