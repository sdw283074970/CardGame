using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegotiationCardManager : MonoBehaviour
{
    public NegotiationCard NegotiationCardAsset;

    [Header("Text Ref")]
    public string NameText;
    public string DescriptionText;
    public int Power;
    public int Times;
    public int Cost;

    [Header("Image Frame Ref")]
    public Sprite CardFaceFrameImage;
    public Sprite CardFaceGlowImage;
    public Sprite CardBackGlowImage;
    public Sprite CardBodyImage;

    [Header("Image Ctor Ref")]
    public Sprite CardCostImage;
    public Sprite CardTitleImage;
    public Sprite RarityStoneImage;
    public Sprite CardGraphicImage;
    public Sprite CardDescriptionImage;
    public Sprite CardPowerImage; //左下角
    public Sprite CardTimesImage; //右下角
}
