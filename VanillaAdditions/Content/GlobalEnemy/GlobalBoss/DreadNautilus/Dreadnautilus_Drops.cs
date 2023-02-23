using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class Dreadnautilus_Drops : GlobalNPC
    {
        public override void ModifyNPCLoot(Terraria.NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BloodNautilus)
            {
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsExpert(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));

                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.Nautilus_Relic>()));

                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadConchItem>())); //Make this have a 25% of being given to players on boss kill
            }
        }
    }
}
