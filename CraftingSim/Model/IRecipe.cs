using System;
using System.Collections.Generic;


namespace CraftingSim.Model
{
    /// <summary>
    /// Represents a Recipe with required materials and quantities to 
    /// craft an item.
    /// Recipes are ordered alphabetically by name. 
    /// </summary>
    public interface IRecipe : IComparable<IRecipe>
    {
        //Name of the recipe
        string Name { get; }
        //Materials and quantities required to craft an item with this recipe
        IReadOnlyDictionary<IMaterial, int> RequiredMaterials { get; }
        //Probability of success when trying to craft an item from this recipe
        double SuccessRate { get; }
    }

    public int CompareTo(IRecipe other)
    {
        if (other == null) return 1;

        return Name.CompareTo(other.Name);
    }
}