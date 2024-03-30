using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoContentView : ContentView
{
    [SerializeField] private InfoConfig _config;
    [SerializeField] private Text _textExample;
    [SerializeField] private Image _imageExample;

    private void Awake()
    {
        for (int i = 0; i < _config.Info.Length; i++)
        {
            if (_config.Info[i].Text != "")
            {
                var textObj = Instantiate(_textExample, _textExample.transform.parent);
                textObj.text = _config.Info[i].Text;
            }
            if (_config.Info[i].Image)
            {
                var imageObj = Instantiate(_imageExample, _imageExample.transform.parent);
                imageObj.sprite = _config.Info[i].Image;
            }
        }
        _textExample.gameObject.SetActive(false);
        _imageExample.gameObject.SetActive(false);
    }
}
