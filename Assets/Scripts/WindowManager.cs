using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField] private string[] _windowNames;
    public string[] WindowNames => _windowNames;

    private Action<string> _onSwitchWindow;

    public void Subscribe(Action<string> methode)
    {
        _onSwitchWindow += methode;
    }

    private void OnDestroy()
    {
        _onSwitchWindow = null;
    }

    public void SwitchWindow(string windowName)
    {
        _onSwitchWindow?.Invoke(windowName);
    }
}
