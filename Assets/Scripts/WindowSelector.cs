using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowSelector : MonoBehaviour
{
    [SerializeField] private ViewSelectorData _activeView;
    [SerializeField] private ViewSelectorData _inactiveView;
    private string _windowName;

    private Action<string> OnClick;

    [Serializable]
    public struct ViewSelectorData
    {
        public GameObject Parent;
        public Text Text;
    }
    
    public Action<string> Initialize(Action<string> methode, string windowName, bool first)
    {
        OnClick += methode;
        _windowName = windowName;

        if (first)
        {
            _activeView.Parent.SetActive(true);
            _inactiveView.Parent.SetActive(false);
        }
        else
        {
            _activeView.Parent.SetActive(false);
            _inactiveView.Parent.SetActive(true);
        }
        
        _activeView.Text.text = _windowName;
        _inactiveView.Text.text = _windowName;

        return ChangeActive;
    }

    public void Click()
    {
        OnClick?.Invoke(_windowName);
    }

    private void OnDestroy()
    {
        OnClick = null;
    }

    private void ChangeActive(string windowName)
    {
        if (_windowName == windowName)
        {
            _activeView.Parent.SetActive(true);
            _inactiveView.Parent.SetActive(false);
        }
        else
        {
            _activeView.Parent.SetActive(false);
            _inactiveView.Parent.SetActive(true);
        }
    }
}