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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
public partial class PGNParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WHITE_WINS=1, BLACK_WINS=2, DRAWN_GAME=3, REST_OF_LINE_COMMENT=4, BRACE_COMMENT=5, 
		ESCAPE=6, SPACES=7, STRING=8, INTEGER=9, PERIOD=10, ASTERISK=11, LEFT_BRACKET=12, 
		RIGHT_BRACKET=13, LEFT_PARENTHESIS=14, RIGHT_PARENTHESIS=15, LEFT_ANGLE_BRACKET=16, 
		RIGHT_ANGLE_BRACKET=17, NUMERIC_ANNOTATION_GLYPH=18, SYMBOL=19, SUFFIX_ANNOTATION=20, 
		UNEXPECTED_CHAR=21;
	public const int
		RULE_parse = 0, RULE_pgn_database = 1, RULE_pgn_game = 2, RULE_tag_section = 3, 
		RULE_tag_pair = 4, RULE_tag_name = 5, RULE_tag_value = 6, RULE_movetext_section = 7, 
		RULE_element_sequence = 8, RULE_element = 9, RULE_move_number_indication = 10, 
		RULE_san_move = 11, RULE_recursive_variation = 12, RULE_game_termination = 13;
	public static readonly string[] ruleNames = {
		"parse", "pgn_database", "pgn_game", "tag_section", "tag_pair", "tag_name", 
		"tag_value", "movetext_section", "element_sequence", "element", "move_number_indication", 
		"san_move", "recursive_variation", "game_termination"
	};

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

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static PGNParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PGNParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PGNParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ParseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Pgn_databaseContext pgn_database() {
			return GetRuleContext<Pgn_databaseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(PGNParser.Eof, 0); }
		public ParseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parse; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParse(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParseContext parse() {
		ParseContext _localctx = new ParseContext(Context, State);
		EnterRule(_localctx, 0, RULE_parse);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28;
			pgn_database();
			State = 29;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Pgn_databaseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Pgn_gameContext[] pgn_game() {
			return GetRuleContexts<Pgn_gameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Pgn_gameContext pgn_game(int i) {
			return GetRuleContext<Pgn_gameContext>(i);
		}
		public Pgn_databaseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pgn_database; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPgn_database(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Pgn_databaseContext pgn_database() {
		Pgn_databaseContext _localctx = new Pgn_databaseContext(Context, State);
		EnterRule(_localctx, 2, RULE_pgn_database);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((_la) & ~0x3f) == 0 && ((1L << _la) & 809486L) != 0) {
				{
				{
				State = 31;
				pgn_game();
				}
				}
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Pgn_gameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Tag_sectionContext tag_section() {
			return GetRuleContext<Tag_sectionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Movetext_sectionContext movetext_section() {
			return GetRuleContext<Movetext_sectionContext>(0);
		}
		public Pgn_gameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pgn_game; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPgn_game(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Pgn_gameContext pgn_game() {
		Pgn_gameContext _localctx = new Pgn_gameContext(Context, State);
		EnterRule(_localctx, 4, RULE_pgn_game);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37;
			tag_section();
			State = 38;
			movetext_section();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tag_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Tag_pairContext[] tag_pair() {
			return GetRuleContexts<Tag_pairContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Tag_pairContext tag_pair(int i) {
			return GetRuleContext<Tag_pairContext>(i);
		}
		public Tag_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tag_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTag_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tag_sectionContext tag_section() {
		Tag_sectionContext _localctx = new Tag_sectionContext(Context, State);
		EnterRule(_localctx, 6, RULE_tag_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LEFT_BRACKET) {
				{
				{
				State = 40;
				tag_pair();
				}
				}
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tag_pairContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEFT_BRACKET() { return GetToken(PGNParser.LEFT_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Tag_nameContext tag_name() {
			return GetRuleContext<Tag_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Tag_valueContext tag_value() {
			return GetRuleContext<Tag_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHT_BRACKET() { return GetToken(PGNParser.RIGHT_BRACKET, 0); }
		public Tag_pairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tag_pair; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTag_pair(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tag_pairContext tag_pair() {
		Tag_pairContext _localctx = new Tag_pairContext(Context, State);
		EnterRule(_localctx, 8, RULE_tag_pair);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			Match(LEFT_BRACKET);
			State = 47;
			tag_name();
			State = 48;
			tag_value();
			State = 49;
			Match(RIGHT_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tag_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYMBOL() { return GetToken(PGNParser.SYMBOL, 0); }
		public Tag_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tag_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTag_name(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tag_nameContext tag_name() {
		Tag_nameContext _localctx = new Tag_nameContext(Context, State);
		EnterRule(_localctx, 10, RULE_tag_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			Match(SYMBOL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tag_valueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(PGNParser.STRING, 0); }
		public Tag_valueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tag_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTag_value(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Tag_valueContext tag_value() {
		Tag_valueContext _localctx = new Tag_valueContext(Context, State);
		EnterRule(_localctx, 12, RULE_tag_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 53;
			Match(STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Movetext_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Element_sequenceContext element_sequence() {
			return GetRuleContext<Element_sequenceContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Game_terminationContext game_termination() {
			return GetRuleContext<Game_terminationContext>(0);
		}
		public Movetext_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_movetext_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMovetext_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Movetext_sectionContext movetext_section() {
		Movetext_sectionContext _localctx = new Movetext_sectionContext(Context, State);
		EnterRule(_localctx, 14, RULE_movetext_section);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			element_sequence();
			State = 56;
			game_termination();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Element_sequenceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ElementContext[] element() {
			return GetRuleContexts<ElementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElementContext element(int i) {
			return GetRuleContext<ElementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Recursive_variationContext[] recursive_variation() {
			return GetRuleContexts<Recursive_variationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Recursive_variationContext recursive_variation(int i) {
			return GetRuleContext<Recursive_variationContext>(i);
		}
		public Element_sequenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_element_sequence; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElement_sequence(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Element_sequenceContext element_sequence() {
		Element_sequenceContext _localctx = new Element_sequenceContext(Context, State);
		EnterRule(_localctx, 16, RULE_element_sequence);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((_la) & ~0x3f) == 0 && ((1L << _la) & 803328L) != 0) {
				{
				State = 60;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case INTEGER:
				case NUMERIC_ANNOTATION_GLYPH:
				case SYMBOL:
					{
					State = 58;
					element();
					}
					break;
				case LEFT_PARENTHESIS:
					{
					State = 59;
					recursive_variation();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 64;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Move_number_indicationContext move_number_indication() {
			return GetRuleContext<Move_number_indicationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public San_moveContext san_move() {
			return GetRuleContext<San_moveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMERIC_ANNOTATION_GLYPH() { return GetToken(PGNParser.NUMERIC_ANNOTATION_GLYPH, 0); }
		public ElementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_element; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElementContext element() {
		ElementContext _localctx = new ElementContext(Context, State);
		EnterRule(_localctx, 18, RULE_element);
		try {
			State = 68;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INTEGER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 65;
				move_number_indication();
				}
				break;
			case SYMBOL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 66;
				san_move();
				}
				break;
			case NUMERIC_ANNOTATION_GLYPH:
				EnterOuterAlt(_localctx, 3);
				{
				State = 67;
				Match(NUMERIC_ANNOTATION_GLYPH);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Move_number_indicationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER() { return GetToken(PGNParser.INTEGER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERIOD() { return GetToken(PGNParser.PERIOD, 0); }
		public Move_number_indicationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_move_number_indication; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMove_number_indication(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Move_number_indicationContext move_number_indication() {
		Move_number_indicationContext _localctx = new Move_number_indicationContext(Context, State);
		EnterRule(_localctx, 20, RULE_move_number_indication);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 70;
			Match(INTEGER);
			State = 72;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==PERIOD) {
				{
				State = 71;
				Match(PERIOD);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class San_moveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYMBOL() { return GetToken(PGNParser.SYMBOL, 0); }
		public San_moveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_san_move; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSan_move(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public San_moveContext san_move() {
		San_moveContext _localctx = new San_moveContext(Context, State);
		EnterRule(_localctx, 22, RULE_san_move);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74;
			Match(SYMBOL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Recursive_variationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEFT_PARENTHESIS() { return GetToken(PGNParser.LEFT_PARENTHESIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Element_sequenceContext element_sequence() {
			return GetRuleContext<Element_sequenceContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHT_PARENTHESIS() { return GetToken(PGNParser.RIGHT_PARENTHESIS, 0); }
		public Recursive_variationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_recursive_variation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRecursive_variation(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Recursive_variationContext recursive_variation() {
		Recursive_variationContext _localctx = new Recursive_variationContext(Context, State);
		EnterRule(_localctx, 24, RULE_recursive_variation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76;
			Match(LEFT_PARENTHESIS);
			State = 77;
			element_sequence();
			State = 78;
			Match(RIGHT_PARENTHESIS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Game_terminationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHITE_WINS() { return GetToken(PGNParser.WHITE_WINS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLACK_WINS() { return GetToken(PGNParser.BLACK_WINS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DRAWN_GAME() { return GetToken(PGNParser.DRAWN_GAME, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASTERISK() { return GetToken(PGNParser.ASTERISK, 0); }
		public Game_terminationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_game_termination; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPGNVisitor<TResult> typedVisitor = visitor as IPGNVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGame_termination(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Game_terminationContext game_termination() {
		Game_terminationContext _localctx = new Game_terminationContext(Context, State);
		EnterRule(_localctx, 26, RULE_game_termination);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 80;
			_la = TokenStream.LA(1);
			if ( !(((_la) & ~0x3f) == 0 && ((1L << _la) & 2062L) != 0) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,21,83,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,1,0,1,0,1,
		0,1,1,5,1,33,8,1,10,1,12,1,36,9,1,1,2,1,2,1,2,1,3,5,3,42,8,3,10,3,12,3,
		45,9,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,7,1,8,1,8,5,8,61,
		8,8,10,8,12,8,64,9,8,1,9,1,9,1,9,3,9,69,8,9,1,10,1,10,3,10,73,8,10,1,11,
		1,11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,0,0,14,0,2,4,6,8,10,12,14,16,18,
		20,22,24,26,0,1,2,0,1,3,11,11,75,0,28,1,0,0,0,2,34,1,0,0,0,4,37,1,0,0,
		0,6,43,1,0,0,0,8,46,1,0,0,0,10,51,1,0,0,0,12,53,1,0,0,0,14,55,1,0,0,0,
		16,62,1,0,0,0,18,68,1,0,0,0,20,70,1,0,0,0,22,74,1,0,0,0,24,76,1,0,0,0,
		26,80,1,0,0,0,28,29,3,2,1,0,29,30,5,0,0,1,30,1,1,0,0,0,31,33,3,4,2,0,32,
		31,1,0,0,0,33,36,1,0,0,0,34,32,1,0,0,0,34,35,1,0,0,0,35,3,1,0,0,0,36,34,
		1,0,0,0,37,38,3,6,3,0,38,39,3,14,7,0,39,5,1,0,0,0,40,42,3,8,4,0,41,40,
		1,0,0,0,42,45,1,0,0,0,43,41,1,0,0,0,43,44,1,0,0,0,44,7,1,0,0,0,45,43,1,
		0,0,0,46,47,5,12,0,0,47,48,3,10,5,0,48,49,3,12,6,0,49,50,5,13,0,0,50,9,
		1,0,0,0,51,52,5,19,0,0,52,11,1,0,0,0,53,54,5,8,0,0,54,13,1,0,0,0,55,56,
		3,16,8,0,56,57,3,26,13,0,57,15,1,0,0,0,58,61,3,18,9,0,59,61,3,24,12,0,
		60,58,1,0,0,0,60,59,1,0,0,0,61,64,1,0,0,0,62,60,1,0,0,0,62,63,1,0,0,0,
		63,17,1,0,0,0,64,62,1,0,0,0,65,69,3,20,10,0,66,69,3,22,11,0,67,69,5,18,
		0,0,68,65,1,0,0,0,68,66,1,0,0,0,68,67,1,0,0,0,69,19,1,0,0,0,70,72,5,9,
		0,0,71,73,5,10,0,0,72,71,1,0,0,0,72,73,1,0,0,0,73,21,1,0,0,0,74,75,5,19,
		0,0,75,23,1,0,0,0,76,77,5,14,0,0,77,78,3,16,8,0,78,79,5,15,0,0,79,25,1,
		0,0,0,80,81,7,0,0,0,81,27,1,0,0,0,6,34,43,60,62,68,72
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
