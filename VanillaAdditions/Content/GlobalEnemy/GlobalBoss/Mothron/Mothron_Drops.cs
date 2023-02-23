using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using VanillaAdditions.Items;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.Mothron
{
    public class Mothron_Drops : GlobalNPC
    {
        public override void ModifyNPCLoot(Terraria.NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Mothron)
            {
                //npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ModContent.ItemType<DreadNautilus_Trophy_Item>()));
                //npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsExpert(), ModContent.ItemType<DreadNautilus_Trophy_Item>()));
                //npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<DreadNautilus_Trophy_Item>()));

                //npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Nautilus_Relic>()));

                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<MothronBabyItem>())); //Make this have a 25% of being given to players on boss kill
            }
        }
    }
}
