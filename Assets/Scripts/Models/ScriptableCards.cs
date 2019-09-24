using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetingOptions
{
    NoTarget,
    AllCreatures,
    EnemyCreatures,
    YourCreatures,
    AllCharacters,
    EnemyCharacters,
    YourCharacters
}

public enum RarityOptions
{
    Basic, Common, Rare, Epic, Legendary
}

public enum TypeOfCard
{
    Status, Policy, Event, Asset, Negotiation, Treaty
}

public enum TypeOfNegotiationCard
{
    Deterrence, Counter, Bargaining, Strategy
}

public class NegotiationCard : ScriptableObject, IComparable<NegotiationCard>
{
    [Header("General Info")]
    public string CardName;
    public Sprite CardTemplate;
    public Sprite CardImage;
    [Range(1, 1000)]
    public int Cost;
    [TextArea(2, 3)]
    public string Description;
    [TextArea(2, 3)]
    public string Tags;
    public TypeOfCard TypeOfCard;
    public TypeOfNegotiationCard TypeOfNegotiationCard;
    public RarityOptions Rarity;

    [Header("Negotiation Info")]
    [Range(0, 2)]
    public float Times;
    [Range(1, 1000)]
    public int ThreatValue;
    [Range(1, 1000)]
    public int CounterValue;
    [Range(1, 1000)]
    public int BargainingChip;

    [Header("Strategy Info")]
    public string StrategyScriptName;
    public TargetingOptions Targets;

    public int CompareTo(NegotiationCard other)
    {
        return 0;
    }
}
