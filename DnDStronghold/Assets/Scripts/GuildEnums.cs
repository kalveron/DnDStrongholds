using UnityEngine;

namespace SecMon.Guild
{
    public enum StrongholdFocus
    {
        Unknown = 0,
        Lab = 1,
        Mine = 2,
        Outpost = 3,
        Garrison = 4,
        Factory = 5,
        Warehouse = 6,
    }

    public enum Proficiency
    {
        None = 0,
        Other = 1,
        Secondary = 2,
        Primary = 3,
    }

    public enum Encounter
    {
        Stealth = 0,
        Diplomacy = 1,
        Perception = 2,
        Combat = 3,
    }

    public enum Background
    {
        Unknown = 0,
        Hireling = 1,
        Friend = 2,
        Loyalist = 3,
        Prominent = 4,
    }

    public enum Loyalty
    {
        Unknown = 0,
        Hostile = 1,
        Conditional = 2,
        Strong = 3,
        Complete = 4,
    }

    public enum GeographicLocation
    {
        Unknown = 0,
        Strost = 1,
        Valden = 2,
        CastleNeverlight = 3,
        Gustrika = 4,
        Nante = 5,
        Baklava = 6,
        Seawatch = 7,
        Vilideema = 8,
        EastLongTalonMountains = 9,
        WestLongTalonMountains = 10,
        DarkReachForest = 11,
        SunsEdgeWood = 12,
    }

    public enum Proximity
    {
        Unknown = 0,
        Central = 1,
        Outskirts = 2,
        Woods = 3,
        Underneath = 4,
        Above = 5,
    }

    public enum KnowledgeLevel
    {
        None = 0,
        Low = 1,
        Moderate = 2,
        High = 3,
    }

    public enum ControlLevel
    {
        Unknown = 0,
        Weak = 1,
        Moderate = 2,
        Strong = 3,
        Complete = 4,
    }

    public enum RumorLevel
    {
        None = 0,
        HitOrMiss = 1,
        Noisy = 2,
        Reliable = 3
    }

    public enum AwarenessLevel
    {
    }

    public enum AgentClass
    {
        Spy = 1,
        Face = 2,
        Brute = 3,
        Noble = 4,
        Merchant = 5,
    }

    public enum ClueAttribute
    {
        Unknown = 0,
        Secret = 1,
        Stronghold = 2,
        Location = 3,
        Counter = 4,
    }

    public enum ClueSource
    {
        Unknown = 0,
        Rumor = 1,
        Document = 2,
        Item = 3,
        Encrypted = 4,
    }

    public enum ClueResult
    {
        None = 0,
        Knowledge = 1,
        Noise = 2,
        RedHerring = 3,
    }

    public enum Security
    {
        Unknown = 0,
        Low = 1,
        Moderate = 2,
        High = 3,
        Critical = 4,
    }

    public enum SecretAttribute
    {
        Unknown = 0,
        PointOfInterest = 1,
        Defense = 2,
        Target = 3,
        Deadline = 4,
        Date = 5,
        Map = 6,
    }

    public enum TaskTarget
    {
        Unknown = 0,
        Rumor = 1,
        Secret = 2,
        Stronghold = 3,
        Location = 4,
        Tool = 5,
        Hideout = 6,
        Agent = 6,
        Decryption = 7,
        Sabotage = 8,
        Strike = 9,
        Funding = 10,
    }

    public enum Risk
    {
        None = 0,
        Low = 1,
        Moderate = 2,
        High = 3,
        Impossible = 4,
    }
}