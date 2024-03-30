using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryContentView : ContentView
{
    [SerializeField] private GalleryConfig _config;
    [SerializeField] private GalleryItem _itemExample;

    private void Awake()
    {
        for (int i = 0; i < _config.Sprites.Length; i++)
        {
            var itemObj = Instantiate(_itemExample, _itemExample.transform.parent);
            itemObj.Image.sprite = _config.Sprites[i];
        }
        _itemExample.gameObject.SetActive(false);
    }
}
