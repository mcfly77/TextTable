//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g 2012-09-28 10:58:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019

package eu.reitmayer.texttable.lang;

using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class TextTableParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ALIGN_LEFT", "ALIGN_RIGHT", "BEGIN", "BY", "Digit", "END", "FROM", "ID", "INT", "LENGTH", "Letter", "PLAIN", "PLAIN_ELEM", "PLAIN_ELEM_LIST", "PLAIN_FILE", "SEPARATED", "TEXT_COMMA", "TEXT_SEMICOLON", "TO", "WS", "';'"
	};
	public const int EOF=-1;
	public const int T__24=24;
	public const int ALIGN_LEFT=4;
	public const int ALIGN_RIGHT=5;
	public const int BEGIN=6;
	public const int BY=7;
	public const int Digit=8;
	public const int END=9;
	public const int FROM=10;
	public const int ID=11;
	public const int INT=12;
	public const int LENGTH=13;
	public const int Letter=14;
	public const int PLAIN=15;
	public const int PLAIN_ELEM=16;
	public const int PLAIN_ELEM_LIST=17;
	public const int PLAIN_FILE=18;
	public const int SEPARATED=19;
	public const int TEXT_COMMA=20;
	public const int TEXT_SEMICOLON=21;
	public const int TO=22;
	public const int WS=23;

	public TextTableParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public TextTableParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
		OnCreated();
	}
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}

		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return TextTableParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_table_desc();
	partial void LeaveRule_table_desc();

	// $ANTLR start "table_desc"
	// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:23:8: public table_desc : ( plain_descr | sep_descr );
	[GrammarRule("table_desc")]
	public AstParserRuleReturnScope<object, IToken> table_desc()
	{
		EnterRule_table_desc();
		EnterRule("table_desc", 1);
		TraceIn("table_desc", 1);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		AstParserRuleReturnScope<object, IToken> plain_descr1 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> sep_descr2 = default(AstParserRuleReturnScope<object, IToken>);

		try { DebugEnterRule(GrammarFileName, "table_desc");
		DebugLocation(23, 1);
		try
		{
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:23:18: ( plain_descr | sep_descr )
			int alt1=2;
			try { DebugEnterDecision(1, false);
			int LA1_0 = input.LA(1);

			if ((LA1_0==PLAIN))
			{
				alt1 = 1;
			}
			else if ((LA1_0==SEPARATED))
			{
				alt1 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 1, 0, input);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:24:2: plain_descr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(24, 2);
				PushFollow(Follow._plain_descr_in_table_desc76);
				plain_descr1=plain_descr();
				PopFollow();

				adaptor.AddChild(root_0, plain_descr1.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:26:2: sep_descr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(26, 2);
				PushFollow(Follow._sep_descr_in_table_desc82);
				sep_descr2=sep_descr();
				PopFollow();

				adaptor.AddChild(root_0, sep_descr2.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("table_desc", 1);
			LeaveRule("table_desc", 1);
			LeaveRule_table_desc();
		}
		DebugLocation(27, 1);
		} finally { DebugExitRule(GrammarFileName, "table_desc"); }
		return retval;

	}
	// $ANTLR end "table_desc"

	partial void EnterRule_plain_descr();
	partial void LeaveRule_plain_descr();

	// $ANTLR start "plain_descr"
	// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:30:1: plain_descr : PLAIN ID BEGIN pl= plain_elem_list END ';' -> ^( PLAIN_FILE ID $pl) ;
	[GrammarRule("plain_descr")]
	private AstParserRuleReturnScope<object, IToken> plain_descr()
	{
		EnterRule_plain_descr();
		EnterRule("plain_descr", 2);
		TraceIn("plain_descr", 2);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken PLAIN3 = default(IToken);
		IToken ID4 = default(IToken);
		IToken BEGIN5 = default(IToken);
		IToken END6 = default(IToken);
		IToken char_literal7 = default(IToken);
		AstParserRuleReturnScope<object, IToken> pl = default(AstParserRuleReturnScope<object, IToken>);

		object PLAIN3_tree = default(object);
		object ID4_tree = default(object);
		object BEGIN5_tree = default(object);
		object END6_tree = default(object);
		object char_literal7_tree = default(object);
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_PLAIN=new RewriteRuleITokenStream(adaptor,"token PLAIN");
		RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_plain_elem_list=new RewriteRuleSubtreeStream(adaptor,"rule plain_elem_list");
		try { DebugEnterRule(GrammarFileName, "plain_descr");
		DebugLocation(30, 1);
		try
		{
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:30:12: ( PLAIN ID BEGIN pl= plain_elem_list END ';' -> ^( PLAIN_FILE ID $pl) )
			DebugEnterAlt(1);
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:31:2: PLAIN ID BEGIN pl= plain_elem_list END ';'
			{
			DebugLocation(31, 2);
			PLAIN3=(IToken)Match(input,PLAIN,Follow._PLAIN_in_plain_descr95);  
			stream_PLAIN.Add(PLAIN3);

			DebugLocation(31, 8);
			ID4=(IToken)Match(input,ID,Follow._ID_in_plain_descr97);  
			stream_ID.Add(ID4);

			DebugLocation(32, 2);
			BEGIN5=(IToken)Match(input,BEGIN,Follow._BEGIN_in_plain_descr100);  
			stream_BEGIN.Add(BEGIN5);

			DebugLocation(33, 6);
			PushFollow(Follow._plain_elem_list_in_plain_descr107);
			pl=plain_elem_list();
			PopFollow();

			stream_plain_elem_list.Add(pl.Tree);
			DebugLocation(34, 2);
			END6=(IToken)Match(input,END,Follow._END_in_plain_descr110);  
			stream_END.Add(END6);

			DebugLocation(34, 6);
			char_literal7=(IToken)Match(input,24,Follow._24_in_plain_descr112);  
			stream_24.Add(char_literal7);



			{
			// AST REWRITE
			// elements: ID, pl
			// token labels: 
			// rule labels: retval, pl
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_pl=new RewriteRuleSubtreeStream(adaptor,"rule pl",pl!=null?pl.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 34:10: -> ^( PLAIN_FILE ID $pl)
			{
				DebugLocation(34, 13);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:34:13: ^( PLAIN_FILE ID $pl)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(34, 15);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PLAIN_FILE, "PLAIN_FILE"), root_1);

				DebugLocation(34, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(34, 30);
				adaptor.AddChild(root_1, stream_pl.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("plain_descr", 2);
			LeaveRule("plain_descr", 2);
			LeaveRule_plain_descr();
		}
		DebugLocation(35, 1);
		} finally { DebugExitRule(GrammarFileName, "plain_descr"); }
		return retval;

	}
	// $ANTLR end "plain_descr"

	partial void EnterRule_sep_descr();
	partial void LeaveRule_sep_descr();

	// $ANTLR start "sep_descr"
	// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:37:1: sep_descr : SEPARATED BEGIN END ';' ;
	[GrammarRule("sep_descr")]
	private AstParserRuleReturnScope<object, IToken> sep_descr()
	{
		EnterRule_sep_descr();
		EnterRule("sep_descr", 3);
		TraceIn("sep_descr", 3);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken SEPARATED8 = default(IToken);
		IToken BEGIN9 = default(IToken);
		IToken END10 = default(IToken);
		IToken char_literal11 = default(IToken);

		object SEPARATED8_tree = default(object);
		object BEGIN9_tree = default(object);
		object END10_tree = default(object);
		object char_literal11_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "sep_descr");
		DebugLocation(37, 1);
		try
		{
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:37:10: ( SEPARATED BEGIN END ';' )
			DebugEnterAlt(1);
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:38:2: SEPARATED BEGIN END ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(38, 2);
			SEPARATED8=(IToken)Match(input,SEPARATED,Follow._SEPARATED_in_sep_descr133); 
			SEPARATED8_tree = (object)adaptor.Create(SEPARATED8);
			adaptor.AddChild(root_0, SEPARATED8_tree);
			DebugLocation(39, 2);
			BEGIN9=(IToken)Match(input,BEGIN,Follow._BEGIN_in_sep_descr136); 
			BEGIN9_tree = (object)adaptor.Create(BEGIN9);
			adaptor.AddChild(root_0, BEGIN9_tree);
			DebugLocation(40, 2);
			END10=(IToken)Match(input,END,Follow._END_in_sep_descr139); 
			END10_tree = (object)adaptor.Create(END10);
			adaptor.AddChild(root_0, END10_tree);
			DebugLocation(40, 6);
			char_literal11=(IToken)Match(input,24,Follow._24_in_sep_descr141); 
			char_literal11_tree = (object)adaptor.Create(char_literal11);
			adaptor.AddChild(root_0, char_literal11_tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("sep_descr", 3);
			LeaveRule("sep_descr", 3);
			LeaveRule_sep_descr();
		}
		DebugLocation(41, 1);
		} finally { DebugExitRule(GrammarFileName, "sep_descr"); }
		return retval;

	}
	// $ANTLR end "sep_descr"

	partial void EnterRule_plain_elem_list();
	partial void LeaveRule_plain_elem_list();

	// $ANTLR start "plain_elem_list"
	// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:43:1: plain_elem_list : (p+= plain_elem )+ -> ^( PLAIN_ELEM_LIST ( $p)+ ) ;
	[GrammarRule("plain_elem_list")]
	private AstParserRuleReturnScope<object, IToken> plain_elem_list()
	{
		EnterRule_plain_elem_list();
		EnterRule("plain_elem_list", 4);
		TraceIn("plain_elem_list", 4);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		List<object> list_p = null;
		AstParserRuleReturnScope<object, IToken> p = default(AstParserRuleReturnScope<object, IToken>);
		RewriteRuleSubtreeStream stream_plain_elem=new RewriteRuleSubtreeStream(adaptor,"rule plain_elem");
		try { DebugEnterRule(GrammarFileName, "plain_elem_list");
		DebugLocation(43, 1);
		try
		{
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:43:16: ( (p+= plain_elem )+ -> ^( PLAIN_ELEM_LIST ( $p)+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:44:2: (p+= plain_elem )+
			{
			DebugLocation(44, 3);
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:44:3: (p+= plain_elem )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_0 = input.LA(1);

				if ((LA2_0==ID))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:44:3: p+= plain_elem
					{
					DebugLocation(44, 3);
					PushFollow(Follow._plain_elem_in_plain_elem_list153);
					p=plain_elem();
					PopFollow();

					stream_plain_elem.Add(p.Tree);
					if (list_p==null) list_p=new List<object>();
					list_p.Add(p.Tree);


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }



			{
			// AST REWRITE
			// elements: p
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: p
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_p=new RewriteRuleSubtreeStream(adaptor,"token p",list_p);
			root_0 = (object)adaptor.Nil();
			// 44:17: -> ^( PLAIN_ELEM_LIST ( $p)+ )
			{
				DebugLocation(44, 20);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:44:20: ^( PLAIN_ELEM_LIST ( $p)+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(44, 22);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PLAIN_ELEM_LIST, "PLAIN_ELEM_LIST"), root_1);

				DebugLocation(44, 39);
				if (!(stream_p.HasNext))
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_p.HasNext )
				{
					DebugLocation(44, 39);
					adaptor.AddChild(root_1, stream_p.NextTree());

				}
				stream_p.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("plain_elem_list", 4);
			LeaveRule("plain_elem_list", 4);
			LeaveRule_plain_elem_list();
		}
		DebugLocation(45, 1);
		} finally { DebugExitRule(GrammarFileName, "plain_elem_list"); }
		return retval;

	}
	// $ANTLR end "plain_elem_list"

	partial void EnterRule_plain_elem();
	partial void LeaveRule_plain_elem();

	// $ANTLR start "plain_elem"
	// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:47:1: plain_elem : ( ID FROM i1= INT TO i2= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )? -> ^( ID $i1 $i2 ( $al)? ) | ID LENGTH i1= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )? -> ^( ID $i1 ( $al)? ) );
	[GrammarRule("plain_elem")]
	private AstParserRuleReturnScope<object, IToken> plain_elem()
	{
		EnterRule_plain_elem();
		EnterRule("plain_elem", 5);
		TraceIn("plain_elem", 5);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken i1 = default(IToken);
		IToken i2 = default(IToken);
		IToken al = default(IToken);
		IToken ID12 = default(IToken);
		IToken FROM13 = default(IToken);
		IToken TO14 = default(IToken);
		IToken ID15 = default(IToken);
		IToken LENGTH16 = default(IToken);

		object i1_tree = default(object);
		object i2_tree = default(object);
		object al_tree = default(object);
		object ID12_tree = default(object);
		object FROM13_tree = default(object);
		object TO14_tree = default(object);
		object ID15_tree = default(object);
		object LENGTH16_tree = default(object);
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ALIGN_RIGHT=new RewriteRuleITokenStream(adaptor,"token ALIGN_RIGHT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_FROM=new RewriteRuleITokenStream(adaptor,"token FROM");
		RewriteRuleITokenStream stream_TO=new RewriteRuleITokenStream(adaptor,"token TO");
		RewriteRuleITokenStream stream_ALIGN_LEFT=new RewriteRuleITokenStream(adaptor,"token ALIGN_LEFT");
		RewriteRuleITokenStream stream_LENGTH=new RewriteRuleITokenStream(adaptor,"token LENGTH");
		try { DebugEnterRule(GrammarFileName, "plain_elem");
		DebugLocation(47, 2);
		try
		{
			// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:47:11: ( ID FROM i1= INT TO i2= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )? -> ^( ID $i1 $i2 ( $al)? ) | ID LENGTH i1= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )? -> ^( ID $i1 ( $al)? ) )
			int alt5=2;
			try { DebugEnterDecision(5, false);
			int LA5_0 = input.LA(1);

			if ((LA5_0==ID))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1==FROM))
				{
					alt5 = 1;
				}
				else if ((LA5_1==LENGTH))
				{
					alt5 = 2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:3: ID FROM i1= INT TO i2= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )?
				{
				DebugLocation(48, 3);
				ID12=(IToken)Match(input,ID,Follow._ID_in_plain_elem177);  
				stream_ID.Add(ID12);

				DebugLocation(48, 6);
				FROM13=(IToken)Match(input,FROM,Follow._FROM_in_plain_elem179);  
				stream_FROM.Add(FROM13);

				DebugLocation(48, 13);
				i1=(IToken)Match(input,INT,Follow._INT_in_plain_elem183);  
				stream_INT.Add(i1);

				DebugLocation(48, 18);
				TO14=(IToken)Match(input,TO,Follow._TO_in_plain_elem185);  
				stream_TO.Add(TO14);

				DebugLocation(48, 23);
				i2=(IToken)Match(input,INT,Follow._INT_in_plain_elem189);  
				stream_INT.Add(i2);

				DebugLocation(48, 28);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:28: (al= ALIGN_LEFT |al= ALIGN_RIGHT )?
				int alt3=3;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, false);
				int LA3_0 = input.LA(1);

				if ((LA3_0==ALIGN_LEFT))
				{
					alt3 = 1;
				}
				else if ((LA3_0==ALIGN_RIGHT))
				{
					alt3 = 2;
				}
				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:29: al= ALIGN_LEFT
					{
					DebugLocation(48, 31);
					al=(IToken)Match(input,ALIGN_LEFT,Follow._ALIGN_LEFT_in_plain_elem194);  
					stream_ALIGN_LEFT.Add(al);


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:45: al= ALIGN_RIGHT
					{
					DebugLocation(48, 47);
					al=(IToken)Match(input,ALIGN_RIGHT,Follow._ALIGN_RIGHT_in_plain_elem200);  
					stream_ALIGN_RIGHT.Add(al);


					}
					break;

				}
				} finally { DebugExitSubRule(3); }



				{
				// AST REWRITE
				// elements: al, i1, ID, i2
				// token labels: al, i2, i1
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_al=new RewriteRuleITokenStream(adaptor,"token al",al);
				RewriteRuleITokenStream stream_i2=new RewriteRuleITokenStream(adaptor,"token i2",i2);
				RewriteRuleITokenStream stream_i1=new RewriteRuleITokenStream(adaptor,"token i1",i1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 48:62: -> ^( ID $i1 $i2 ( $al)? )
				{
					DebugLocation(48, 65);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:65: ^( ID $i1 $i2 ( $al)? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(48, 67);
					root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

					DebugLocation(48, 71);
					adaptor.AddChild(root_1, stream_i1.NextNode());
					DebugLocation(48, 75);
					adaptor.AddChild(root_1, stream_i2.NextNode());
					DebugLocation(48, 79);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:48:79: ( $al)?
					if (stream_al.HasNext)
					{
						DebugLocation(48, 79);
						adaptor.AddChild(root_1, stream_al.NextNode());

					}
					stream_al.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:3: ID LENGTH i1= INT (al= ALIGN_LEFT |al= ALIGN_RIGHT )?
				{
				DebugLocation(50, 3);
				ID15=(IToken)Match(input,ID,Follow._ID_in_plain_elem226);  
				stream_ID.Add(ID15);

				DebugLocation(50, 6);
				LENGTH16=(IToken)Match(input,LENGTH,Follow._LENGTH_in_plain_elem228);  
				stream_LENGTH.Add(LENGTH16);

				DebugLocation(50, 15);
				i1=(IToken)Match(input,INT,Follow._INT_in_plain_elem232);  
				stream_INT.Add(i1);

				DebugLocation(50, 20);
				// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:20: (al= ALIGN_LEFT |al= ALIGN_RIGHT )?
				int alt4=3;
				try { DebugEnterSubRule(4);
				try { DebugEnterDecision(4, false);
				int LA4_0 = input.LA(1);

				if ((LA4_0==ALIGN_LEFT))
				{
					alt4 = 1;
				}
				else if ((LA4_0==ALIGN_RIGHT))
				{
					alt4 = 2;
				}
				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:21: al= ALIGN_LEFT
					{
					DebugLocation(50, 23);
					al=(IToken)Match(input,ALIGN_LEFT,Follow._ALIGN_LEFT_in_plain_elem237);  
					stream_ALIGN_LEFT.Add(al);


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:37: al= ALIGN_RIGHT
					{
					DebugLocation(50, 39);
					al=(IToken)Match(input,ALIGN_RIGHT,Follow._ALIGN_RIGHT_in_plain_elem243);  
					stream_ALIGN_RIGHT.Add(al);


					}
					break;

				}
				} finally { DebugExitSubRule(4); }



				{
				// AST REWRITE
				// elements: ID, i1, al
				// token labels: al, i1
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_al=new RewriteRuleITokenStream(adaptor,"token al",al);
				RewriteRuleITokenStream stream_i1=new RewriteRuleITokenStream(adaptor,"token i1",i1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 50:54: -> ^( ID $i1 ( $al)? )
				{
					DebugLocation(50, 57);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:57: ^( ID $i1 ( $al)? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(50, 59);
					root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

					DebugLocation(50, 63);
					adaptor.AddChild(root_1, stream_i1.NextNode());
					DebugLocation(50, 67);
					// C:\\Users\\freitmay\\SkyDrive\\Dokumente\\workspace\\TextTable\\src\\eu\\reitmayer\\texttable\\lang\\TextTable.g:50:67: ( $al)?
					if (stream_al.HasNext)
					{
						DebugLocation(50, 67);
						adaptor.AddChild(root_1, stream_al.NextNode());

					}
					stream_al.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("plain_elem", 5);
			LeaveRule("plain_elem", 5);
			LeaveRule_plain_elem();
		}
		DebugLocation(51, 2);
		} finally { DebugExitRule(GrammarFileName, "plain_elem"); }
		return retval;

	}
	// $ANTLR end "plain_elem"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _plain_descr_in_table_desc76 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _sep_descr_in_table_desc82 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLAIN_in_plain_descr95 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _ID_in_plain_descr97 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _BEGIN_in_plain_descr100 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _plain_elem_list_in_plain_descr107 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _END_in_plain_descr110 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _24_in_plain_descr112 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SEPARATED_in_sep_descr133 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _BEGIN_in_sep_descr136 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _END_in_sep_descr139 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _24_in_sep_descr141 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _plain_elem_in_plain_elem_list153 = new BitSet(new ulong[]{0x802UL});
		public static readonly BitSet _ID_in_plain_elem177 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _FROM_in_plain_elem179 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _INT_in_plain_elem183 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _TO_in_plain_elem185 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _INT_in_plain_elem189 = new BitSet(new ulong[]{0x32UL});
		public static readonly BitSet _ALIGN_LEFT_in_plain_elem194 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ALIGN_RIGHT_in_plain_elem200 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_plain_elem226 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _LENGTH_in_plain_elem228 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _INT_in_plain_elem232 = new BitSet(new ulong[]{0x32UL});
		public static readonly BitSet _ALIGN_LEFT_in_plain_elem237 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ALIGN_RIGHT_in_plain_elem243 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}
