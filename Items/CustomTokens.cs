using ExperienceAndClasses;
using ExperienceAndClasses.Abilities;
using ExperienceAndClasses.Items;
using ExperienceAndClasses.Recipes;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ACTerraModpack.Items
{
    /* Squire */
    public class ClassToken_Bard : ClassToken_Novice
    {
        public ClassToken_Bard()
        {
            name = "Bard";
            tier = 2;
            desc = "Basic melee damage and life class." +
                       "\n\nClass advancement is available at level 45.";
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ExperienceAndClasses.Recipes.ClassRecipes(mod, tier);
            recipe.AddRecipeGroup("IronBar", 10);
            Commons.QuckRecipe(mod, new int[,] { { mod.ItemType("ClassToken_Novice"), 1 } }, this, 1, recipe);
        }
    }
}
