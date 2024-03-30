using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ViewBuilder : MonoBehaviour
{
    [SerializeField] private RectTransform _upContainer;

    [Inject]
    public void Initialize(WindowManager manager, WindowSelector selectorPrefab, ContentView[] contents)
    {
        for (int i = 0; i < manager.WindowNames.Length; i++)
        {
            var windowName = manager.WindowNames[i];
            var selector = Instantiate(selectorPrefab, _upContainer);
            manager.Subscribe(selector.Initialize(manager.SwitchWindow, windowName, i==0));
            manager.Subscribe(contents[i].Initialize(windowName, i==0));
        }
    }
}
