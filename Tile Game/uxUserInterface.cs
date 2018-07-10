using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Game
{
    public partial class uxUserInterface : Form
    {
        private int _boardWidth = 8;
        private int _boardHeight = 8;
        private GameLogic _game;

        /// <summary>
        /// Controls the sequence of spawn events
        /// </summary>
        public uxUserInterface()
        {
            InitializeComponent();
            DrawGameField();
        }
        /// <summary>
        /// Creates the game field containing player and enemy objects
        /// </summary>
        private void DrawGameField()
        {
            //sets the sizes of the gui
            uxGameBoard.Width = 60 * _boardWidth;
            uxGameBoard.Height = uxGameBoard.Width + 30;

            _game = new GameLogic(_boardHeight, _boardWidth);
            for (int r = _boardHeight - 1; r > 0; r--)
            {
                for (int c = _boardWidth - 1; c > 0; c--)
                {

                    Label tile = new Label();
                    tile.Width = 60;
                    tile.Height = 60;

                    tile.BackColor = FindColor(_game.GetTile(r,c).Terrain);
                    tile.Image = FindImage(_game.GetTile(r, c).objectName);

                }
            }
        }

        /// <summary>
        /// This function should iterate over each row of the board and
        /// update each Label that represents a board square.
        /// </summary>
        private void RedrawBoard()
        {
            BoardTile currentSquare = null;
            for (int row = _boardHeight; row > 0; row--)
            {
                for(int column = _boardWidth; column > 0; column--)
                {
                    currentSquare = _game.GetTile(row, column);
                    Label square = (Label)uxGameBoard.Controls[currentSquare.Row + "," + currentSquare.Column];

                    if (currentSquare.Selected)
                    {
                        square.BackColor = Color.Aqua;
                    }
                    else
                        square.Image = FindImage(_game.GetTile(row,column).objectName);
                }
            }
        }
        public Color FindColor(SquareTerrain terrain)
        {
            switch (terrain)
            {
                case SquareTerrain.Desert:
                    return Color.Wheat;
                case SquareTerrain.Grass:
                    return Color.LawnGreen;
                case SquareTerrain.Ice:
                    return Color.LightCyan;
                case SquareTerrain.River:
                    return Color.Aqua;
                case SquareTerrain.Snow:
                    return Color.Snow;
                case SquareTerrain.Woods:
                    return Color.ForestGreen;
                default:
                    return Color.Empty;
            }
        }

        public Image FindImage(UnitType unit)
        {
            switch (unit)
            {
                case UnitType.Infantry:
                    return null;
                default:
                    return null;
            }
        }

        private void BoardSquare_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Console.WriteLine(label.Name);
            string[] split = label.Name.Split(',');
            if (_game.MakeMove(Convert.ToInt32(split[0]), Convert.ToInt32(split[1])))
            {

                RedrawBoard();

                SquareStatus win = _game.CheckWin();
                if (win != SquareStatus.None)
                {
                    MessageBox.Show("The winner is: " + win);
                }
            }
            else
            {
                MessageBox.Show("Invalid move!");
            }

            uxTurnLabel.Text = "Turn: " + _game.Turn;
        }

        private void ux8by8_Click(object sender, EventArgs e)
        {
            _boardHeight = 8;
            _boardWidth = 8;
            DrawGameField();
        }
    }//end of main
}//end of namespace