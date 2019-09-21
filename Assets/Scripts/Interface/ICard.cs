using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
    string CardName { get; set; } //卡片名称

    string Description { get; set; } //卡片描述
}

//政策卡，为政策系统的最终输出之一
public interface IPolicyCard : ICard
{

}

//社会状态卡，为事件系统、政策系统、谈判系统的输出之一
public interface ISocialStatusCard : ICard
{
    bool IsNegativeStatus { get; set; } //区分是否是负面状态卡
}

//条约卡，为事件系统、政策系统、谈判系统的输出之一
public interface ITreatyCard : ICard
{
    int Price { get; set; }

    IList<ISocialStatusCard> SocialStatusCards { get; set; }

    IList<IAssetCard> AssetCards { get; set; }
}

//谈判卡，为资产卡转换系统的输出
public interface INegotiationCard : ICard
{
    string NegotiationType { get; set; } //威胁卡、反制卡、筹码卡、特殊效果卡

    int ThreatValue { get; set; } //威胁卡的关键属性值

    int CounterValue { get; set; } //反制卡的关键属性值

    int BargainingChip { get; set; } //筹码卡的关键属性值

    int Cost { get; set; }
}

//资产卡，为事件系统、政策系统、谈判系统的最终输出之一
public interface IAssetCard : ICard
{
    IList<INegotiationCard> NegotiationCards { get; set; } //一张资产卡可以转换成多种谈判卡
}
