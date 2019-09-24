using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetCard : MonoBehaviour, IAssetCard
{
    public string CardName { get; set; }
    public string NegotiationType { get; set; }
    public string Rarity { get; set; }
    public string Description { get; set; }
    public string Tags { get; set; }
    public Sprite CardTemplate { get; set; }
    public Sprite CardImage { get; set; }
    public string TypeOfCard { get; set; }
    IList<NegotiationCard> IAssetCard.NegotiationCards { get; set; }
}
