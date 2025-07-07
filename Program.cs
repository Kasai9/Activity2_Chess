// File: Program.cs
using System;
using System.Collections.Generic;
using ChessLogic;   //  logic namespace

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();

            while (true)
            {
                Console.WriteLine("Enter piece type (None, King, Queen, Rook, Bishop, Knight, Pawn) or blank to exit:");
                string typeInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(typeInput))
                    break;

                if (!Enum.TryParse(typeInput, true, out PieceType pieceType))
                {
                    Console.WriteLine("  Invalid piece. Try again.");
                    continue;
                }

                Console.WriteLine("Enter color (White or Black):");
                string colorInput = Console.ReadLine();
                if (!Enum.TryParse(colorInput, true, out PieceColor color))
                {
                    Console.WriteLine("  Invalid color. Try again.");
                    continue;
                }

                Console.WriteLine("Enter row (0–7):");
                if (!int.TryParse(Console.ReadLine(), out int row) || row < 0 || row > 7)
                {
                    Console.WriteLine("  Invalid row. Try again.");
                    continue;
                }

                Console.WriteLine("Enter column (0–7):");
                if (!int.TryParse(Console.ReadLine(), out int col) || col < 0 || col > 7)
                {
                    Console.WriteLine("  Invalid column. Try again.");
                    continue;
                }

                //Place the piece
                var cell = board.GetCell(row, col);
                cell.Piece = pieceType;
                cell.Color = color;

                // Get legal moves and print the board
                List<Point> moves = board.GetLegalMoves(row, col);
                PrintBoard(board, moves);

                Console.WriteLine("Press Enter to try another piece, or type EXIT to quit.");
                string next = Console.ReadLine();
                if (next?.Equals("EXIT", StringComparison.OrdinalIgnoreCase) == true)
                    break;

                // Clear that piece before the next run
                cell.Piece = PieceType.None;
            }
        }

        // draw board with '*' marking legal moves
        static void PrintBoard(Board board, List<Point> moves)
        {
            Console.Write("   ");
            for (int c = 0; c < 8; c++)
                Console.Write(c + " ");
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write(r + "  ");
                for (int c = 0; c < 8; c++)
                {
                    var cell = board.GetCell(r, c);
                    bool isMove = moves.Exists(p => p.X == r && p.Y == c);
                    char symbol = isMove
                        ? '*'
                        : cell.Piece == PieceType.None
                            ? '.'
                            : cell.ToString()[0];

                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
