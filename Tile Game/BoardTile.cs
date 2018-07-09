using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Game
{
    /// <summary>
    /// Controls the state of the current tile
    /// </summary>
    public enum SquareStatus
    {
        Friendly,
        Enemy,
        Player,
        None
    }
    /// <summary>
    /// Controls the current terrain on the tile
    /// </summary>
    public enum SquareTerrain
    {
        Woods,
        Grass,
        River,
        Desert,
        Snow,
        Ice
    }
    /// <summary>
    /// Controls the unit type
    /// </summary>
    public enum UnitType
    {
        Infantry
    }
    class BoardTile
    {
        /// <summary>
        /// Name of the current object
        /// </summary>
        private UnitType _objectName;
        /// <summary>
        /// Getter and setter methods for the object's name
        /// </summary>
        public UnitType objectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }
        /// <summary>
        /// Stores the object's hitpoints
        /// </summary>
        private int _hitpoints;
        /// <summary>
        /// Getter end setter methods to contorl the object's hitpoints
        /// </summary>
        public int hitpoints
        {
            get { return _hitpoints; }
            set { _hitpoints = value; }
        }
        /// <summary>
        /// Indicates if this square contains an enemy, player or if it has no piece
        /// </summary>
        public SquareStatus State;
        /// <summary>
        /// Indicates the type of terrain on this tile
        /// </summary>
        public SquareTerrain Terrain;
        /// <summary>
        /// Indicates if this square is selected
        /// </summary>
        public bool Selected;
        /// <summary>
        /// The row location on the board
        /// </summary>
        public int Row;
        /// <summary>
        /// The column location on the board
        /// </summary>
        public int Column;
        /// <summary>
        /// Controls the position of any given board piece
        /// </summary>
        /// <param name="row">horizontal tile coordinate</param>
        /// <param name="column">vertical tile coordinate</param>
        public BoardTile(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }//end of the BoardTile class
}//end of namespace
