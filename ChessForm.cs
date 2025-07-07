using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChessLogic;

namespace ChessGUI
{
    public partial class ChessForm : Form
    {
        private Button[,] buttons = new Button[8, 8];
        private Board board = new Board();

        public ChessForm()
        {
            InitializeComponent();
            InitializeBoard();
            rdoLight.Checked = true; // default theme
        }

        // Create the 8x8 grid of buttons dynamically
        private void InitializeBoard()
        {
            tblBoard.RowCount = 8;
            tblBoard.ColumnCount = 8;
            tblBoard.Controls.Clear();
            tblBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int r = 0; r < 8; r++)
            {
                tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
                for (int c = 0; c < 8; c++)
                {
                    tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));

                    var btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(0);
                    btn.Tag = new System.Drawing.Point(r, c); // store location
                    btn.Click += Btn_Click;

                    buttons[r, c] = btn;
                    tblBoard.Controls.Add(btn, c, r);
                }
            }

            ApplyTheme();
        }

        // Hanndle square clicks: place piece and mark legal moves
        private void Btn_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn)) return;
            var point = (System.Drawing.Point)btn.Tag;

            var selectedPiece = cmbPieceType.SelectedItem?.ToString();
            var selectedColor = cmbPieceColor.SelectedItem?.ToString();

            if (!Enum.TryParse(selectedPiece, out PieceType pieceType) ||
                !Enum.TryParse(selectedColor, out PieceColor color))
            {
                MessageBox.Show("Please select both a piece and a color.");
                return;
            }

            // Clear board state first
            foreach (var b in buttons)
                b.Text = "";

            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                    board.GetCell(r, c).Piece = PieceType.None;

            // Place piece and color
            var cell = board.GetCell(point.X, point.Y);
            cell.Piece = pieceType;
            cell.Color = color;

            btn.Text = pieceType.ToString()[0].ToString();

            // Get and mark legal moves
            var moves = board.GetLegalMoves(point.X, point.Y);
            foreach (var p in moves)
            {
                buttons[p.X, p.Y].Text = "*";
            }

            lblStatus.Text = $"{moves.Count} legal move(s) found.";
        }

        // Applies light or dark theme to buttons
        private void ApplyTheme()
        {
            Color light1, light2;
            if (rdoLight.Checked)
            {
                light1 = Color.Beige;
                light2 = Color.SaddleBrown;
            }
            else
            {
                light1 = Color.Silver;
                light2 = Color.DimGray;
            }

            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    buttons[r, c].BackColor = (r + c) % 2 == 0 ? light1 : light2;
                    buttons[r, c].ForeColor = Color.Black;
                    buttons[r, c].Text = "";
                }
            }

            lblStatus.Text = "Theme applied.";
        }

        // Event: theme changed
        private void rdoLight_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void rdoDark_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        // Event: Clear Board button clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var b in buttons)
                b.Text = "";

            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                    board.GetCell(r, c).Piece = PieceType.None;

            lblStatus.Text = "Board cleared.";
        }
    }
}
