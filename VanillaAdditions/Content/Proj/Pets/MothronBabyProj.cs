using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;         //Make it so if the pet is really far away it squirts a bunch of blood porpelling itself towards the player
using VanillaAdditions.Buffs;

namespace VanillaAdditions.Content.Proj.Pets

{
    public class MothronBabyProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spawn of the Black Sun");
            Main.projFrames[Projectile.type] = 3; //divides the sheet by this number to get frame size
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }
        public override void SetDefaults()
        {
            Projectile.width = 32; //hitbox size
            Projectile.height = 30;
            Projectile.aiStyle = 26;
            Projectile.friendly = true;
            Projectile.penetrate = -1; //i think this just means it will infinitly penetrate
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            AIType = ProjectileID.ZephyrFish; // Copy the AI of the x
        }
        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            // Projectile no die like this
            if (!player.dead && player.HasBuff(ModContent.BuffType<MothronBabyBuff>()))
            {
                Projectile.timeLeft = 2;
            }

            Projectile.frameCounter -= 2; //this part is courtise of naylddd, i could not for the life of me figure it out
            if (Projectile.frameCounter <= -6)
            {
                Projectile.frameCounter = 0;
                Projectile.frame = (Projectile.frame + 1) % Main.projFrames[Projectile.type];
            }

            Main.projFrames[Type] = 3;

            if (!Main.dedServ)
            {
                Lighting.AddLight(Projectile.Center, Projectile.Opacity * 0.9f, Projectile.Opacity * 0.1f, Projectile.Opacity * 0.3f); //make it much less intense
            }
        }
    }
}
