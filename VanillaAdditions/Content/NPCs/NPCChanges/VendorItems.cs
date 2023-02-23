using VanillaAdditions.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
//shop.item[nextSlot].shopSpecialCurrency = CustomCurrencyID.DefenderMedals; // omit this line if shopCustomPrice should be in regular coins.
//Witch doctor - Plantera
//Pirate - Pirate invasion
//Truffle - Duke fishron
//Cyborg - Martian invasion
//Wizard - Pumpkin moon
//Wizard - Frost moon
//Wizard - Celestial sigil

namespace VanillaAdditions.Content.NPCs.NPCChanges
{
    class VanillaAdditions : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Clothier)
            {
                if (NPC.downedBoss3 == true)
                {
                    shop.item[nextSlot].SetDefaults(1307); //clothier doll
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++; // Do not forget this.
                }
                if (NPC.downedBoss3 == true)
                {
                    shop.item[nextSlot].SetDefaults(267); //VooDooDoll
                    shop.item[nextSlot].shopCustomPrice = 75000;
                    nextSlot++;
                }
;
            }

            if (type == NPCID.Merchant)
            {
                shop.item[nextSlot].SetDefaults(2997); //wormhole potions.
                shop.item[nextSlot].shopCustomPrice = 1000;
                nextSlot++;

                if (NPC.downedSlimeKing == true)
                {
                    shop.item[nextSlot].SetDefaults(560); //(ItemID.WetCrown);
                    shop.item[nextSlot].shopCustomPrice = 20000;
                    nextSlot++;
                }
                if (NPC.downedBoss1 == true) //donwedboss1 checks to see if EoC is dead
                {
                    shop.item[nextSlot].SetDefaults(43); //(ItemID.SusEye);
                    shop.item[nextSlot].shopCustomPrice = 30000;
                    nextSlot++;
                }
                if (Main.dayTime == true)
                {
                    shop.item[nextSlot].SetDefaults(282); //(ItemID.SusEye);
                    shop.item[nextSlot].shopCustomPrice = 7;
                    nextSlot++;
                }
            }

            if (type == NPCID.Dryad) //checks if the npc is as follows, can be used to set drops for certain mobs or add items to npc shops.
            {
                if (NPC.downedBoss2 == true) //donwedboss2 checks to see if BoC/EoW are dead
                {
                    shop.item[nextSlot].SetDefaults(1331); //(ItemID.BloodySpine);
                    shop.item[nextSlot].shopCustomPrice = 75000;
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(70); //worm food
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
                if (NPC.downedQueenSlime == true) ;
                {
                    shop.item[nextSlot].SetDefaults(4988); //Gelatin Crystal
                    shop.item[nextSlot].shopCustomPrice = 70000;
                    nextSlot++;
                }
            }

            if (type == NPCID.WitchDoctor)
            {
                if (NPC.downedDeerclops == true)
                {
                    shop.item[nextSlot].SetDefaults(5120); //deer thing.
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
                if (NPC.downedQueenBee == true)
                {
                    shop.item[nextSlot].SetDefaults(1133); //queenbee
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
                if (NPC.downedGolemBoss == true)
                {
                    shop.item[nextSlot].SetDefaults(1293);
                    shop.item[nextSlot].shopCustomPrice = 15000;
                    nextSlot++;
                }
;
            }
            if (type == NPCID.Steampunker) //Might be the wrong mech boss
            {
                if (NPC.downedMechBoss1 == true)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm); //Mechanical worm boss
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
                if (NPC.downedMechBoss2 == true)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye); //Mechanical worm boss
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
                if (NPC.downedMechBoss3 == true)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull); //Mechanical worm boss
                    shop.item[nextSlot].shopCustomPrice = 50000;
                    nextSlot++;
                }
            }
        }
    }
}