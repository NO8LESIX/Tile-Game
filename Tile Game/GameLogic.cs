using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Game
{
    class GameLogic
    {
        /// <summary>
        /// Keeps track of the enemy units on the board
        /// </summary>
        private int _enemyUnits;
        /// <summary>
        /// Keeps track of the player controlled units on the board
        /// </summary>
        private int _playerUnits;
        /// <summary>
        /// Keeps track of the friendly units on the board, if any.
        /// </summary>
        private int _friendlyUnits;
        /// <summary>
        /// 2D array that controls the game board
        /// </summary>
        private BoardTile[,] _gameBoard;
        /// <summary>
        /// Getter to return the game board array.
        /// </summary>
        public BoardTile[,] gameBoard
        {
            get { return _gameBoard; }
        }

        /// <summary>
        /// Property to keep track of the currently selected tile
        /// </summary>
        public BoardTile SelectedTile;

        /// <summary>
        /// Property to keep track of whose turn it is
        /// </summary>
        public SquareStatus Turn;

        /// <summary>
        /// Class constructor that uses the given 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public GameLogic(int row, int column)
        {
            Createboard(row, column);
            Turn = SquareStatus.Player;
        }

        /// <summary>
        /// Generates the game board
        /// </summary>
        /// <param name="row"></param>
        /// <param name="colum"></param>
        private void Createboard(int row, int column)
        {
            //Creates a new tileset size row x column
            _gameBoard = new BoardTile[row, column];

            for (int r = row - 1; r >= 0; r--)
            {
                for (int c = column - 1; c >= 0; c--)
                {
                    BoardTile tile = new BoardTile(r, c);
                    tile.Terrain = SquareTerrain.Grass;

                    if (r == row - 1)
                    {
                        tile.State = SquareStatus.Enemy;
                        tile.Terrain = SquareTerrain.Woods;
                        _enemyUnits++;
                    }
                    else if (r == row-row)
                    {
                        tile.State = SquareStatus.Player;
                        tile.Terrain = SquareTerrain.Woods;
                        _playerUnits++;
                    }
                    else
                    {
                        tile.State = SquareStatus.None;
                        tile.Terrain = SquareTerrain.Grass;
                    }
                    _gameBoard[r, c] = tile;
                }
            }
        }

        /// <summary>
        /// This function attempts to make a legal move in the target row/column and returns true if a move is made.
        /// </summary>
        /// <param name="targetRow">row of the selected tile</param>
        /// <param name="targetCol">column of the selected tile</param>
        /// <returns></returns>
        public bool MakeMove(int targetRow, int targetCol)
        {
            BoardTile target = SelectSquare(targetRow, targetCol);
            if (SelectedTile == null)
                return false;
            if (SelectedTile == target)
            {
                return true;
            }
            else if (SelectedTile != null && target.State == SquareStatus.None)
            {
                if (SelectedTile.State == SquareStatus.Enemy)
                    target.State = SelectedTile.State;
                SelectedTile.State = SquareStatus.None;
                SelectedTile.Selected = false;
                SelectedTile = null;

                Turn = Turn == SquareStatus.Enemy ? SquareStatus.Enemy : SquareStatus.Player;

                return true;
            }
            else if (SelectedTile != null && target.State != SquareStatus.None)
            {
                BoardTile end;
                //if(CheckAttack())
                return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Finds and returns the BoardSquare that corresponds to the given row and column.
        /// If the found square has the same color as the current Turn, the square should be stored in SelectedPiece.
        /// Be sure to set the Selected variable of the BoardSquare if this is the case.
        /// </summary>
        /// <param name="row">given row passed to identify the dictionary key</param>
        /// <param name="col">given column to identify the linked list</param>
        /// <returns></returns>
        private BoardTile SelectSquare(int row, int col)
        {
            BoardTile tile = _gameBoard[row, col];

            if (tile.State != SquareStatus.None && tile.State == Turn)
            {
                if (SelectedTile != null)
                {
                    SelectedTile.Selected = false;
                }
                SelectedTile = tile;
                SelectedTile.Selected = true;
            }

            return tile;
        }

        /// <summary>
        /// Returns the victor if either when enemy or the player wins.
        /// Returns SquareStatus.Friendly if the allied units have been defeated
        /// Returns SquareStatus.None otherwise.
        /// </summary>
        /// <returns></returns>
        public SquareStatus CheckWin()
        {
            if (_enemyUnits == 0)
                return SquareStatus.Player;
            else if (_playerUnits == 0)
                return SquareStatus.Enemy;
            else if (_friendlyUnits == 0)
                return SquareStatus.Friendly;
            else
                return SquareStatus.None;
        }

        /// <summary>
        /// Returns the tile if it exists
        /// </summary>
        /// <param name="row">row marker searcher for the indicated tile</param>
        /// <param name="column">column marker searcher for the indicated tile</param>
        /// <returns></returns>
        public BoardTile GetTile(int row, int column)
        {
            try
            {
                return _gameBoard[row, column];

            }
            catch (Exception ex)
            {
                return null;
            }
        }




    }//end of class
}//end of namespace
