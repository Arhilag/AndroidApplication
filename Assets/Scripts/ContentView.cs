using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class ContentView : MonoBehaviour
{
    private string _windowName;
    
    public Action<string> Initialize(string windowName, bool first)
    {
        _windowName = windowName;

        if (first)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
        
        return ChangeActive;
    }
    
    private void ChangeActive(string windowName)
    {
        if (_windowName == windowName)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
