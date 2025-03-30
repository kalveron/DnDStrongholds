using UnityEngine;

namespace SecMon
{
    public enum Skill
    {
        Strength = 0,
        Constitution = 1,
        Dexertity = 2,
        Intelligence = 3,
        Wisdom = 4,
        Charisma = 5,
    }

    public enum Quality
    {
        None = 0,
        Mundane = 1,
        Magical = 2,
    }

    public enum Roll
    {
        Standard = 0,
        Disadvantage = 1,
        Advantage = 2,
    }

    public enum Rarity
    {
        Common = 0,
        Uncommon = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,
        Artifact = 5,
    }
}