using Terraria;
using Terraria.ModLoader;

namespace VanillaAdditions.Content.GlobalItems
{
    public class Whips : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == 4911) //CoolWhip
            {
                item.autoReuse = true;
            }
            if (item.type == 4680) //DarkHarvest
            {
                item.autoReuse = true;
            }
            if (item.type == 4678) //Durendal
            {
                item.autoReuse = true;
            }
            if (item.type == 4912) //FireCracker
            {
                item.autoReuse = true;
            }
            if (item.type == 4913) //Snapthorn
            {
                item.autoReuse = true;
            }
            if (item.type == 4914) //Kaleidoscope
            {
                item.autoReuse = true;
            }
            if (item.type == 4672) //LeatherWhip
            {
                item.autoReuse = true;
            }
            if (item.type == 4679) //MorningStar
            {
                item.autoReuse = true;
            }
            if (item.type == 5074) //SpinalTap
            {
                item.autoReuse = true;
            }
        }
    }
}
