using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CardUnityIntergration : MonoBehaviour
{
    [MenuItem("Assets/Create/Card Assets/Negotiation Card")]
    public static void CreateNegotiationCardScriptableObject()
    {
        ScriptableObjectUtility.CreateAsset<NegotiationCard>();
    }
}

public static class ScriptableObjectUtility
{
    public static void  CreateAsset<T>() where T : ScriptableObject
    {
        var asset = ScriptableObject.CreateInstance<T>();
        ProjectWindowUtil.CreateAsset(asset, "New " + typeof(T).Name + ".asset");
    }
}

