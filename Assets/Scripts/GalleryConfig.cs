using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GalleryConfig", menuName = "Configs/GalleryConfig", order = 1)]
public class GalleryConfig : ScriptableObject
{
    [SerializeField] private Sprite[] _spritesData;
    public Sprite[] Sprites => _spritesData;
}
