using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using VanillaAdditions.Proj.Pets;

namespace VanillaAdditions.Content.Buffs
{
    public class MothronBabyBuff : ModBuff
    {
        public override string Texture => "VanillaAdditions/Assets/Buffs/MothronBaby";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Baby Mothron");
            Description.SetDefault("It's so fuzzy!");

            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            int projType = ModContent.ProjectileType<MothronBabyProj>();
            // If the player is local, and there hasn't been a pet projectile spawned yet - spawn it.
            if (player.whoAmI == Main.myPlayer && player.ownedProjectileCounts[projType] <= 0)
            {
                var entitySource = player.GetSource_Buff(buffIndex); //what do these 2 lines do idk

                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, projType, 0, 0f, player.whoAmI);
            }
        }
    }
}

