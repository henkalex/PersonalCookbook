﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalCookbook.Dal.Interfaces;
using PersonalCookbook.Models;

namespace PersonalCookbook.Dal.Stub
{
    public class StubRecipeContext : IRecipeContext
    {
        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            recipes.Add(new Recipe("TomatenSoep", "Chantal", 4, "blaat", 1));
            recipes.Add(new Recipe("ChampignonSoep", "Rudolph", 3, "schaap", 2));
            return recipes;
        }
    }
}
