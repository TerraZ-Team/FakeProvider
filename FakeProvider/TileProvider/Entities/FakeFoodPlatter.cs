﻿#region Using
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.ID;
#endregion
namespace FakeProvider
{
    public class FakeFoodPlatter : TEFoodPlatter, IFake
    {
        #region Data

        public TileProvider Provider { get; }
        public int Index
        {
            get => ID;
            set => ID = value;
        }
        public int X
        {
            get => Position.X;
            set => Position = new Point16((short)value, Position.Y);
        }
        public int Y
        {
            get => Position.Y;
            set => Position = new Point16(Position.X, (short)value);
        }
        internal static ushort[] _TileTypes = new ushort[]
        {
            TileID.FoodPlatter
        };
        public ushort[] TileTypes => _TileTypes;
        public int RelativeX { get; set; }
        public int RelativeY { get; set; }

        #endregion

        #region Constructor

        public FakeFoodPlatter(TileProvider Provider, int Index, int X, int Y, Item Item = null)
        {
            this.Provider = Provider;
            this.ID = Index;
            this.RelativeX = X;
            this.RelativeY = Y;
            this.Position = new Point16(X, Y);
            this.type = _myEntityID;
            this.item = Item ?? new Item();
        }

        #endregion
    }
}
