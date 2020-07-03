using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private readonly Dictionary<Allergen, int> allergens = new Dictionary<Allergen, int>()
    {
        { Allergen.Eggs, 1 },
        { Allergen.Peanuts, 2 },
        { Allergen.Shellfish, 4 },
        { Allergen.Strawberries, 8 },
        { Allergen.Tomatoes, 16 },
        { Allergen.Chocolate, 32 },
        { Allergen.Pollen, 64 },
        { Allergen.Cats, 128 },
    };

    private readonly int _allergyScore;
    public Allergies(int allergyScore) => _allergyScore = allergyScore;

    public bool IsAllergicTo(Allergen allergen) => (_allergyScore & allergens[allergen]) != 0;

    public Allergen[] List() => allergens.Keys.Where(allergen => IsAllergicTo(allergen)).ToArray();
}