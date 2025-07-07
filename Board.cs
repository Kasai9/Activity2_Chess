using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    // quick struct for row/col pair
    public struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) { X = x; Y = y; }
    }

    public class Board
    {
        private Cell[,] cells = new Cell[8, 8];

        public Board()
        {
            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                    cells[r, c] = new Cell(r, c);
            // tried MessageBox.Show("test"); for quick debug
        }

        public Cell GetCell(int r, int c)
        {
            if (r < 0 || r > 7 || c < 0 || c > 7)
                return null;
            return cells[r, c];
        }

        public List<Point> GetLegalMoves(int r, int c)
        {
            var moves = new List<Point>();
            var cell = GetCell(r, c);
            if (cell == null || cell.Piece == PieceType.None) return moves;

            switch (cell.Piece)
            {
                case PieceType.Knight:
                    moves.AddRange(GetKnightMoves(r, c));
                    break;
                case PieceType.Bishop:
                    moves.AddRange(GetSlidingMoves(r, c, new[] { new Point(1, 1), new Point(1, -1), new Point(-1, 1), new Point(-1, -1) }));
                    break;
                case PieceType.Rook:
                    moves.AddRange(GetSlidingMoves(r, c, new[] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) }));
                    break;
                case PieceType.Queen:
                    moves.AddRange(GetSlidingMoves(r, c,
                        new[]{ new Point(1,1), new Point(1,-1), new Point(-1,1), new Point(-1,-1),
                               new Point(1,0), new Point(-1,0), new Point(0,1), new Point(0,-1) }));
                    break;
                case PieceType.King:
                    moves.AddRange(GetKingMoves(r, c));
                    break;
                case PieceType.Pawn:
                    moves.AddRange(GetPawnMoves(r, c, cell.Color));
                    break;
            }
            return moves;
        }

        private IEnumerable<Point> GetKnightMoves(int r, int c)
        {
            var deltas = new[]{ new Point(2,1), new Point(1,2), new Point(-1,2), new Point(-2,1),
                                new Point(-2,-1), new Point(-1,-2), new Point(1,-2), new Point(2,-1) };
            foreach (var d in deltas)
            {
                int nr = r + d.X, nc = c + d.Y;
                if (nr >= 0 && nr < 8 && nc >= 0 && nc < 8)
                    yield return new Point(nr, nc);
            }
        }

        private IEnumerable<Point> GetKingMoves(int r, int c)
        {
            for (int dr = -1; dr <= 1; dr++)
                for (int dc = -1; dc <= 1; dc++)
                {
                    if (dr == 0 && dc == 0) continue;
                    int nr = r + dr, nc = c + dc;
                    if (nr >= 0 && nr < 8 && nc >= 0 && nc < 8)
                        yield return new Point(nr, nc);
                }
        }

        // sliding moves: keep stepping in each direction until edge
        private IEnumerable<Point> GetSlidingMoves(int r, int c, Point[] dirs)
        {
            foreach (var d in dirs)
            {
                int nr = r + d.X, nc = c + d.Y;
                while (nr >= 0 && nr < 8 && nc >= 0 && nc < 8)
                {
                    yield return new Point(nr, nc);
                    nr += d.X; nc += d.Y;
                }
            }
        }

        private IEnumerable<Point> GetPawnMoves(int r, int c, PieceColor color)
        {
            int dir = (color == PieceColor.White) ? -1 : 1;
            int nr = r + dir;
            if (nr >= 0 && nr < 8)
            {
                // forward
                yield return new Point(nr, c);
                // diagonal
                if (c - 1 >= 0) yield return new Point(nr, c - 1);
                if (c + 1 < 8) yield return new Point(nr, c + 1);
            }
        }
    }
}
