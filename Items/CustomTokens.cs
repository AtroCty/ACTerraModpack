using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod;

namespace ACTerraModpack.Items
{
    /* Squire */
    public class ClassToken_Bard : ModItem
    {
        public override void SetStaticDefaults()
        {
            String desc = "Basic melee damage and life class.";

            if (Constants.UsingAutoTrash)
            {
                desc += " Get dunked on";
            }
            else
            {
                desc += " Not dunked on";
            }
            Tooltip.SetDefault(desc);
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.value = 0;
            item.rare = 10;
            item.accessory = true;
            if (Constants.UsingThoriumMod)
            {
                // private readonly Mod ModThorium = ModLoader.GetMod("ThoriumMod");
                // readonly ThoriumPlayer thoriumPlayer = player.GetModPlayer<ThoriumPlayer>();
                ThoriumPlayer thoriumPlayer = Main.LocalPlayer.GetModPlayer<ThoriumPlayer>(ModLoader.GetMod("ThoriumMod"));
                thoriumPlayer.bardResourceMax2 += 3;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
