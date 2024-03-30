using UnityEngine;
using Zenject;

public abstract class ContainerView : MonoBehaviour
{
    protected ContainerViewManager Manager;

    [Inject]
    public void SetContainerViewManager(ContainerViewManager manager)
    {
        Manager = manager;
    }
    
    public void Show()
    {
        gameObject.SetActive(true);
    }
    
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}

