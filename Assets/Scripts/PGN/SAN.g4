grammar SAN;

san_game
    : san_sequence san_termination
    ;

san_termination
    : TERMINATE
    ;

san_sequence
    : (san_move)*
    ;

san_move
    : piece_moves
    | piece_moves_A1
    | piece_moves_A2
    | piece_moves_A3
    | piece_move_capture
    | piece_move_capture_A1
    | piece_move_capture_A2
    | piece_move_capture_A3
    | pawn_push
    | pawn_push_promote
    | pawn_capture
    | pawn_capture_A1
    | pawn_capture_promote
    | pawn_capture_promote_A1
    | castle_king
    | castle_queen
    | SYMBOL
    ;

piece_moves
    : MOVE
    ;
piece_moves_A1
    : MOVE_A1
    ;
piece_moves_A2
    : MOVE_A2
    ;
piece_moves_A3
    : MOVE_A3
    ;

piece_move_capture
    : MOVE_CAPTURE
    ;
piece_move_capture_A1
    : MOVE_CAPTURE_A1
    ;
piece_move_capture_A2
    : MOVE_CAPTURE_A2
    ;
piece_move_capture_A3
    : MOVE_CAPTURE_A3
    ;

pawn_push: PAWN_PUSH;
pawn_push_promote: PAWN_PUSH_PROMOTE;
pawn_capture: PAWN_CAPTURE;
pawn_capture_A1: PAWN_CAPTURE_A1;
pawn_capture_promote: PAWN_CAPTURE_PROMOTE;
pawn_capture_promote_A1: PAWN_CAPTURE_PROMOTE_A1;

castle_king: CASTLE_KING;
castle_queen: CASTLE_QUEEN;


// Combine Token

MOVE
    : PIECE_SYMBOL SQUARE CHECK? SUFFIX?
    ;
MOVE_A1
    : PIECE_SYMBOL FILE SQUARE CHECK? SUFFIX?
    ;
MOVE_A2
    : PIECE_SYMBOL RANK SQUARE CHECK? SUFFIX?
    ;
MOVE_A3
    : PIECE_SYMBOL SQUARE SQUARE CHECK? SUFFIX?
    ;
MOVE_CAPTURE
    : PIECE_SYMBOL CAPTURE SQUARE CHECK? SUFFIX?
    ;
MOVE_CAPTURE_A1
    : PIECE_SYMBOL FILE CAPTURE SQUARE CHECK? SUFFIX?
    ;
MOVE_CAPTURE_A2
    : PIECE_SYMBOL RANK CAPTURE SQUARE CHECK? SUFFIX?
    ;
MOVE_CAPTURE_A3
    : PIECE_SYMBOL SQUARE CAPTURE SQUARE CHECK? SUFFIX?
    ;

PAWN_PUSH
    : SQUARE CHECK? SUFFIX?
    ;
PAWN_PUSH_PROMOTE
    : SQUARE PROMOTED_TO CHECK? SUFFIX?
    ;

PAWN_CAPTURE
    :FILE CAPTURE SQUARE CHECK? SUFFIX?
    ;
PAWN_CAPTURE_A1
    :FILE RANK CAPTURE SQUARE CHECK? SUFFIX?
    ;
PAWN_CAPTURE_PROMOTE
    :FILE CAPTURE SQUARE PROMOTED_TO CHECK? SUFFIX?
    ;
PAWN_CAPTURE_PROMOTE_A1
    :FILE RANK CAPTURE SQUARE PROMOTED_TO CHECK? SUFFIX?
    ;

CASTLE_KING:'O-O';
CASTLE_QUEEN: 'O-O-O';


// Tokens
TERMINATE: '____';

PIECE_SYMBOL: [KQBRN];
FILE: [a-h];
RANK: [1-8];
SQUARE: FILE RANK;
CAPTURE: 'x';
PROMOTED_TO: '='[KQBRN];
CHECK: [+#];
SUFFIX: [?!] [?!]?;
SYMBOL
 : [a-zA-Z0-9] [a-zA-Z0-9_+#=:-]*
 ;
SPACES: [ \t\r\n]+ -> skip;

