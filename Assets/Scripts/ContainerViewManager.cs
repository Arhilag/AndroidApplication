using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ContainerViewManager
{
    private List<ContainerView> _views;
    private ContainerView _currentView;
    
    public ContainerViewManager()
    {
        _views = Object.FindObjectsOfType<ContainerView>(true).ToList();
        _currentView = _views[0];
    }

    public void Show<T>() where T : ContainerView
    {
        _currentView.Hide();
        _currentView = _views.Find(view => view.GetType() == typeof(T));
        _currentView.Show();
    }
}
