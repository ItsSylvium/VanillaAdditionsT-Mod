using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using VanillaAdditions.GlobalEnemy.GlobalBoss.DreadNautilus;
using Microsoft.Xna.Framework;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class DreadConchItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Cavier");
            Tooltip.SetDefault("Summons a dreadful shell fish\nThis newborn demon is harmless!"); 

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; //for journey mode
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 18;
            Item.rare = -13; //Rainbow/Expert mode
            Item.shoot = ModContent.ProjectileType<DreadConchPet>();
            Item.buffType = ModContent.BuffType<DreadConchBuff>();
        }
        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600);
            }
        }
    }
}
