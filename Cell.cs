using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ChessLogic
{
    public enum PieceType { None, King, Queen, Rook, Bishop, Knight, Pawn }
    public enum PieceColor { White, Black }

    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public PieceType Piece { get; set; }
        public PieceColor Color { get; set; }

        public Cell(int row, int col)
        {
            Row = row; Col = col;
            Piece = PieceType.None;
            Color = PieceColor.White;
            //Console.WriteLine($"Created Cell at {row},{col}");
            //MessageBox.Show("test");
        }

        public override string ToString()
        {
            if (Piece == PieceType.None)
                return ".";
            // uses  first letter for piece
            return Piece.ToString()[0].ToString();
        }
    }
}