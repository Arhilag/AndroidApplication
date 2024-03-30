using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfoConfig", menuName = "Configs/InfoConfig", order = 0)]
public class InfoConfig : ScriptableObject
{
    [SerializeField] private InfoData[] _infoData;
    public InfoData[] Info => _infoData;
    
    [Serializable]
    public struct InfoData
    {
        [TextArea]
        public string Text;
        public Sprite Image;
    }
}
