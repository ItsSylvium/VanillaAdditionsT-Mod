using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Localization;
using Terraria.DataStructures;
using VanillaAdditions.GlobalEnemy.GlobalBoss.DreadNautilus;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class DreadNautilus_Trophy_Tile : ModTile
    {
        "VanillaAdditions/Assests/Boss/DreadNautilus/DreadNautilus_Trophy_Tile"
        public override void SetStaticDefaults() //you gotta like go through all that fix it its from VA
        {
            DustType = 7;

            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.addTile(Type);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            //AddMapEntry(new Color(120, 85, 60), Language.GetText("MapObject.Trophy")); //fix code and make the color correct //The language part causes you to get text when you hover over it
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>());
        }
    }
}