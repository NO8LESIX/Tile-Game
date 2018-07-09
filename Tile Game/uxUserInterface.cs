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
        private int _boardWidth;
        private int _boardHeight;
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
            for (int r = _boardHeight; r > 0; r--)
            {
                for (int c = _boardWidth; c > 0; c++)
                {

                    Label tile = new Label();
                    tile.Width = 60;
                    tile.Height = 60;

                    switch (_game.GetTile(r,c).Terrain)
                    {
                        case SquareTerrain.Desert:
                            tile.BackColor = Color.Wheat;
                            break;
                        case SquareTerrain.Grass:
                            tile.BackColor = Color.LawnGreen;
                            break;
                        case SquareTerrain.Ice:
                            tile.BackColor = Color.LightCyan;
                            break;
                        case SquareTerrain.River:
                            tile.BackColor = Color.Aqua;
                            break;
                        case SquareTerrain.Snow:
                            tile.BackColor = Color.Snow;
                            break;
                        case SquareTerrain.Woods:
                            tile.BackColor = Color.ForestGreen;
                            break;
                        default:
                            break;
                    }

                    switch (_game.GetTile(r, c).objectName)
                    {
                        case UnitType.Infantry:
                            break;
                        default:
                            break;
                    }

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
                        square.Ima


                }
                
                while (currentSquare != null)
                {
                    Label square = (Label)uxGameBoard.Controls[currentSquare.Data.Row + "," + currentSquare.Data.Column];

                    if (currentSquare.Data.Selected)
                    {
                        square.BackColor = Color.Aqua;
                    }
                    else if (currentSquare.Data.Row % 2 == currentSquare.Data.Column % 2)
                        square.BackColor = Color.White;
                    else
                        square.BackColor = Color.Gray;

                    if (currentSquare.Data.Color == SquareColor.Black)
                        square.Image = _black;
                    else if (currentSquare.Data.Color == SquareColor.Red)
                        square.Image = _red;
                    else
                        square.Image = null;


                    currentSquare = currentSquare.Next;
                }

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

                SquareColor win = _game.CheckWin();
                if (win != SquareColor.None)
                {
                    MessageBox.Show("The winner is ");
                }
            }
            else
            {
                MessageBox.Show("Invalid move!");
            }

            uxStatusLabel.Text = "Turn: " + _game.Turn;
        }

    }//end of main
}//end of namespace