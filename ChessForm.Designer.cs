namespace ChessGUI
{
    partial class ChessForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblBoard = new TableLayoutPanel();
            cmbPieceType = new ComboBox();
            cmbPieceColor = new ComboBox();
            grpTheme = new GroupBox();
            rdoDark = new RadioButton();
            rdoLight = new RadioButton();
            btnClear = new Button();
            lblInstructions = new Label();
            lblStatus = new Label();
            lblPiece = new Label();
            lblColor = new Label();
            grpTheme.SuspendLayout();
            SuspendLayout();
            // 
            // tblBoard
            // 
            tblBoard.ColumnCount = 8;
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4957294F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.50061F));
            tblBoard.Location = new Point(152, 111);
            tblBoard.Name = "tblBoard";
            tblBoard.RowCount = 8;
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblBoard.Size = new Size(500, 500);
            tblBoard.TabIndex = 0;
            // 
            // cmbPieceType
            // 
            cmbPieceType.FormattingEnabled = true;
            cmbPieceType.Items.AddRange(new object[] { "None", "King", "Queen", "Rook", "Bishop", "Knight", "Pawn" });
            cmbPieceType.Location = new Point(705, 571);
            cmbPieceType.Name = "cmbPieceType";
            cmbPieceType.Size = new Size(242, 40);
            cmbPieceType.TabIndex = 1;
            // 
            // cmbPieceColor
            // 
            cmbPieceColor.FormattingEnabled = true;
            cmbPieceColor.Items.AddRange(new object[] { "White", "Black" });
            cmbPieceColor.Location = new Point(1026, 571);
            cmbPieceColor.Name = "cmbPieceColor";
            cmbPieceColor.Size = new Size(242, 40);
            cmbPieceColor.TabIndex = 2;
            // 
            // grpTheme
            // 
            grpTheme.Controls.Add(rdoDark);
            grpTheme.Controls.Add(rdoLight);
            grpTheme.Location = new Point(765, 111);
            grpTheme.Name = "grpTheme";
            grpTheme.Size = new Size(518, 194);
            grpTheme.TabIndex = 3;
            grpTheme.TabStop = false;
            grpTheme.Text = "Theme";
            // 
            // rdoDark
            // 
            rdoDark.AutoSize = true;
            rdoDark.Location = new Point(376, 79);
            rdoDark.Name = "rdoDark";
            rdoDark.Size = new Size(94, 36);
            rdoDark.TabIndex = 1;
            rdoDark.TabStop = true;
            rdoDark.Text = "Dark";
            rdoDark.UseVisualStyleBackColor = true;
            rdoDark.CheckedChanged += rdoDark_CheckedChanged;
            // 
            // rdoLight
            // 
            rdoLight.AutoSize = true;
            rdoLight.Location = new Point(42, 79);
            rdoLight.Name = "rdoLight";
            rdoLight.Size = new Size(98, 36);
            rdoLight.TabIndex = 0;
            rdoLight.TabStop = true;
            rdoLight.Text = "Light";
            rdoLight.UseVisualStyleBackColor = true;
            rdoLight.CheckedChanged += rdoLight_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.AllowDrop = true;
            btnClear.Location = new Point(598, 887);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Board";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(329, 27);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(809, 59);
            lblInstructions.TabIndex = 5;
            lblInstructions.Text = "Select piece and color, then click a square";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(945, 418);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 32);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Ready";
            // 
            // lblPiece
            // 
            lblPiece.AutoSize = true;
            lblPiece.Location = new Point(783, 526);
            lblPiece.Name = "lblPiece";
            lblPiece.Size = new Size(70, 32);
            lblPiece.TabIndex = 7;
            lblPiece.Text = "Piece";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(1114, 526);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(71, 32);
            lblColor.TabIndex = 8;
            lblColor.Text = "Color";
            // 
            // ChessForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1025);
            Controls.Add(lblColor);
            Controls.Add(lblPiece);
            Controls.Add(lblStatus);
            Controls.Add(lblInstructions);
            Controls.Add(btnClear);
            Controls.Add(grpTheme);
            Controls.Add(cmbPieceColor);
            Controls.Add(cmbPieceType);
            Controls.Add(tblBoard);
            Name = "ChessForm";
            Text = "ChessForm";
            grpTheme.ResumeLayout(false);
            grpTheme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblBoard;
        private ComboBox cmbPieceType;
        private ComboBox cmbPieceColor;
        private GroupBox grpTheme;
        private RadioButton rdoDark;
        private RadioButton rdoLight;
        private Button btnClear;
        private Label lblInstructions;
        private Label lblStatus;
        private Label lblPiece;
        private Label lblColor;
    }
}
